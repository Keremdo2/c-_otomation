using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hacettepe_Telekom
{
    public partial class FrmPersonVitrin : Form
    {
        public FrmPersonVitrin()
        {
            InitializeComponent();
        }
        SqlConn bgl = new SqlConn();

        public void Temizle()
        {
            txtVitrinId.Text = "";
            cmbVitrinMarka.Text = "";
            cmbVitrinModel.Text = "";
            cmbVitrinHafiza.Text = "";
            cmbVitrinRam.Text = "";
            rtxtVitrinAciklama.Text = "";

            txtVitrinMusteriAd.Text = "";
            txtVitrinMusteriSoyad.Text = "";
            mtxtVitrinMusteriEmail.Text = "";
            mtxtVitrinMusteriTC.Text = "";
            mtxtVitrinMusteriTel.Text = "";
            cmbVitrinMarka.Focus();
        }
        private void FrmPersonVitrin_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hacettepe_TelekomDataSet1.tbl_vitrin' table. You can move, or remove it, as needed.
            // sql den comboboxa markaları çekme
            SqlCommand command = new SqlCommand("select * from tbl_telefonmarkalar", bgl.baglanti());
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                cmbVitrinMarka.Items.Add(reader["marka_ad"].ToString());
            }
            reader.Close();
            bgl.baglanti().Close();

            // sql den comboboxa hafızaları çekme
            SqlCommand command2 = new SqlCommand("select * from tbl_hafizalar", bgl.baglanti());
            SqlDataReader reader2 = command2.ExecuteReader();
            while (reader2.Read())
            {
                cmbVitrinHafiza.Items.Add(reader2["urun_hafiza"].ToString());
            }
            reader2.Close();
            bgl.baglanti().Close();

            //comboboxa ramleri çekme
            SqlCommand command3 = new SqlCommand("select * from tbl_ramler", bgl.baglanti());
            SqlDataReader reader3 = command3.ExecuteReader();
            while (reader3.Read())
            {
                cmbVitrinRam.Items.Add(reader3["urun_ram"].ToString());
            }
            reader3.Close();
            bgl.baglanti().Close();

            this.tbl_vitrinTableAdapter.Fill(this.hacettepe_TelekomDataSet1.tbl_vitrin);

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // gridden veri çekme
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txtVitrinId.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            cmbVitrinMarka.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            cmbVitrinModel.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            cmbVitrinHafiza.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            cmbVitrinRam.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            txtVitrinFiyat.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            rtxtVitrinAciklama.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
        }

        private void btnVitrinSell_Click(object sender, EventArgs e)
        {
            //Vitrinden ürün çıkarma
            SqlCommand command = new SqlCommand("delete from tbl_vitrin where urun_id=@p1", bgl.baglanti());
            command.Parameters.AddWithValue("@p1", txtVitrinId.Text);
            command.ExecuteNonQuery();
            
            bgl.baglanti().Close();

            //müşteri tablosuna müşteri ekleme
            if (txtVitrinMusteriAd.Text != "" && txtVitrinMusteriSoyad.Text != "" && mtxtVitrinMusteriEmail.Text != "" && mtxtVitrinMusteriTC.Text != "" && mtxtVitrinMusteriTel.Text != "")
            {
            SqlCommand command2 = new SqlCommand("insert into tbl_musteriler (musteri_ad,musteri_soyad,musteri_email,musteri_tel,musteri_TC) values (@p1,@p2,@p3,@p4,@p5)", bgl.baglanti());
            command2.Parameters.AddWithValue("@p1", txtVitrinMusteriAd.Text);
            command2.Parameters.AddWithValue("@p2", txtVitrinMusteriSoyad.Text);
            command2.Parameters.AddWithValue("@p3", mtxtVitrinMusteriEmail.Text);
            command2.Parameters.AddWithValue("@p4", mtxtVitrinMusteriTC.Text);
            command2.Parameters.AddWithValue("@p5", mtxtVitrinMusteriTel.Text);
            command2.ExecuteNonQuery();
            MessageBox.Show("Ürün Satıldı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            bgl.baglanti().Close();

            //Gridi yenileme
            SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM tbl_vitrin", bgl.baglanti());
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            bgl.baglanti().Close();

                lblMusteriAd.Text = txtVitrinMusteriAd.Text;
                lblMusteriSoyad.Text = txtVitrinMusteriSoyad.Text;
                lblMusteriTC.Text = mtxtVitrinMusteriTC.Text;
                lblMusteriTel.Text = mtxtVitrinMusteriTel.Text;

                // Belge oluşturmak için gerekli değişkenler
                string klasorYolu = @"C:\Users\kerem\OneDrive\Masaüstü\görsel3\Hacettepe_Telekom\Satim_Fatura";
                string fileName = "Fatura_" + lblMusteriTC.Text + DateTime.Now.ToString("dd_MM_yyyy_HH_mm_ss") + ".txt";
                string filePath = Path.Combine(klasorYolu, fileName);

                // Belge içeriği
                string documentContent = "Müşteri : " + lblMusteriTC.Text + " " + lblMusteriSoyad.Text + " " + lblMusteriAd.Text + " " + txtVitrinFiyat.Text + " " + "İşlem Tarihi :" + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");

                try
                {
                    // Belgeyi oluştur
                    File.WriteAllText(filePath, documentContent);
                    // MessageBox.Show("Belge oluşturuldu: " + filePath, "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Belge oluşturma işlemi başarısız oldu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                //fatura tablosuna veri ekleme
                SqlCommand command3 = new SqlCommand("insert into tbl_faturalar (fatura_TC,fatura_bedel,fatura_tarih,fatura_tel) values (@p1,@p2,@p3,@p4)", bgl.baglanti());
                command3.Parameters.AddWithValue("@p1", lblMusteriTC.Text);
                command3.Parameters.AddWithValue("@p2", txtVitrinFiyat.Text);
                command3.Parameters.AddWithValue("@p3", DateTime.Now);
                command3.Parameters.AddWithValue("@p4", lblMusteriTel.Text);
                command3.ExecuteNonQuery();
                Temizle();
            }
            else
            {
                MessageBox.Show("Değerler Boş Girilemez!!", "UYARI!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnVitrinGeri_Click(object sender, EventArgs e)
        {
            FrmPersonUI frmPersonUI = new FrmPersonUI();
            frmPersonUI.Show();
            this.Close();
        }

        private void cmbVitrinMarka_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("select model_ad from tbl_modeller where marka_id=@p1", bgl.baglanti());
            command.Parameters.AddWithValue("@p1", cmbVitrinMarka.SelectedIndex);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                cmbVitrinModel.Items.Add(reader[0]);
            }
            bgl.baglanti().Close();
        }


    }
}
