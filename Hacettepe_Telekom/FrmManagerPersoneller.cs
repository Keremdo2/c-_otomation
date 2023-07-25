using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hacettepe_Telekom
{
    public partial class FrmManagerPersoneller : Form
    {
        public FrmManagerPersoneller()
        {
            InitializeComponent();
        }

        public void Temizle()
        {
            txtPersonelId.Text = "";
            txtPersonelAd.Text = "";
            txtPersonelSoyad.Text = "";
            txtPersonelSifre.Text = "";
            txtPersonelSifreTekrar.Text = "";
            txtPersonelMaas.Text = "";
            txtPersonelKadi.Text = "";
            mtxtPersonelTC.Text = "";
            mtxtPersonelTel.Text = "";
            cmbPersonelBirim.Text = "";
            txtPersonelAd.Focus();

        }
        private void FrmManagerPersoneller_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hacettepe_TelekomDataSet3.tbl_personeller' table. You can move, or remove it, as needed.
            this.tbl_personellerTableAdapter.Fill(this.hacettepe_TelekomDataSet3.tbl_personeller);
            // ComboBoxa veri çekme
            SqlCommand command = new SqlCommand("select * from tbl_bolumler", bgl.baglanti());
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                cmbPersonelBirim.Items.Add(reader["bolum_adi"].ToString());
            }
            reader.Close();
            bgl.baglanti().Close();
        }
        SqlConn bgl = new SqlConn();
        private void btnGeriGel_Click(object sender, EventArgs e)
        {
            FrmManagerUI frmManagerUI = new FrmManagerUI();
            frmManagerUI.Show();
            this.Close();
        }

        private void btnPersonelKaydet_Click(object sender, EventArgs e)
        {
            if (txtPersonelAd.Text != "" && txtPersonelSoyad.Text != "" && cmbPersonelBirim.Text != "" && mtxtPersonelTC.Text != "" && mtxtPersonelTel.Text != "" && txtPersonelKadi.Text != "" && txtPersonelSifre.Text != "" && txtPersonelSifreTekrar.Text != "" && txtPersonelMaas.Text != "")
            {
                if (txtPersonelSifre.Text == txtPersonelSifreTekrar.Text)
                {
                    SqlCommand command = new SqlCommand("insert into tbl_personeller (personel_ad,personel_soyad,personel_sifre,personel_maas,Personel_kadi,Personel_TC,Personel_telefon,personel_bolum) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8)", bgl.baglanti());
                    command.Parameters.AddWithValue("@p1", txtPersonelAd.Text);
                    command.Parameters.AddWithValue("@p2", txtPersonelSoyad.Text);
                    command.Parameters.AddWithValue("@p3", txtPersonelSifre.Text);
                    command.Parameters.AddWithValue("@p4", txtPersonelMaas.Text);
                    command.Parameters.AddWithValue("@p5", txtPersonelKadi.Text);
                    command.Parameters.AddWithValue("@p6", mtxtPersonelTC.Text);
                    command.Parameters.AddWithValue("@p7", mtxtPersonelTel.Text);
                    command.Parameters.AddWithValue("@p8", cmbPersonelBirim.Text);
                    command.ExecuteNonQuery();
                    bgl.baglanti().Close();
                    MessageBox.Show("Personel Kaydı Başarı ile Gerçekleşmiştir", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //DataGridView i güncelleme
                    SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM tbl_personeller", bgl.baglanti());
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);
                    dataGridView1.DataSource = dataTable;
                    bgl.baglanti().Close();
                    Temizle();
                }
                else
                {
                    MessageBox.Show("Şifreler Birbiri İle Uyuşmuyor", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Değerler Boş Geçilemez", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // gridden veri çekme
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txtPersonelId.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txtPersonelAd.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txtPersonelSoyad.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            txtPersonelSifre.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            txtPersonelMaas.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            txtPersonelKadi.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            mtxtPersonelTC.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
            mtxtPersonelTel.Text = dataGridView1.Rows[secilen].Cells[7].Value.ToString();
            cmbPersonelBirim.Text = dataGridView1.Rows[secilen].Cells[8].Value.ToString();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if(txtPersonelSifre.UseSystemPasswordChar == false)
            {
                txtPersonelSifre.UseSystemPasswordChar = true;
            }
            else
            {
                txtPersonelSifre.UseSystemPasswordChar=false;
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            if(txtPersonelSifreTekrar.UseSystemPasswordChar == false)
            {
                txtPersonelSifreTekrar.UseSystemPasswordChar =true;
            }
            else
            {
                txtPersonelSifreTekrar.UseSystemPasswordChar = false;
            }
        }

        private void btnPersonelSil_Click(object sender, EventArgs e)
        {
            if(txtPersonelAd.Text != "" && txtPersonelSoyad.Text != "" && cmbPersonelBirim.Text != "" && mtxtPersonelTC.Text != "" && mtxtPersonelTel.Text != "" && txtPersonelKadi.Text != "" && txtPersonelSifre.Text != "" && txtPersonelMaas.Text != "")
            {
                //personel Silme
                SqlCommand command = new SqlCommand("delete from tbl_personeller where  personel_id=@p1", bgl.baglanti());
                command.Parameters.AddWithValue("@p1", txtPersonelId.Text);
                command.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Personel Bilgileri Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //DataGridView i güncelleme
                SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM tbl_personeller", bgl.baglanti());
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
                bgl.baglanti().Close();
                Temizle();
            }
            else
            {
                MessageBox.Show("Değerler Boş Geçilemez", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }       
            
        }

        private void btnPersonelGuncelle_Click(object sender, EventArgs e)
        {
            if(txtPersonelAd.Text != "" && txtPersonelSoyad.Text != "" && cmbPersonelBirim.Text != "" && mtxtPersonelTC.Text != "" && mtxtPersonelTel.Text != "" && txtPersonelKadi.Text != "" && txtPersonelSifre.Text != "" && txtPersonelSifreTekrar.Text != "" && txtPersonelMaas.Text != "")
            {
                //Güncelleme işlemi
                SqlCommand command = new SqlCommand("update tbl_personeller set personel_ad=@p1,personel_soyad=@p2,personel_sifre=@p3,personel_maas=@p4,Personel_kadi=@p5,Personel_TC=@p6,Personel_telefon=@p7,personel_bolum=@p8 where personel_id=@p9",bgl.baglanti());
                command.Parameters.AddWithValue("@p1", txtPersonelAd.Text);
                command.Parameters.AddWithValue("@p2", txtPersonelSoyad.Text);
                command.Parameters.AddWithValue("@p3", txtPersonelSifre.Text);
                command.Parameters.AddWithValue("@p4", txtPersonelMaas.Text);
                command.Parameters.AddWithValue("@p5", txtPersonelKadi.Text);
                command.Parameters.AddWithValue("@p6", mtxtPersonelTC.Text);
                command.Parameters.AddWithValue("@p7", mtxtPersonelTel.Text);
                command.Parameters.AddWithValue("@p8", cmbPersonelBirim.Text);
                command.Parameters.AddWithValue("@p9", txtPersonelId.Text);
                command.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Personel Bilgisi Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //DataGridView i güncelleme
                SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM tbl_personeller", bgl.baglanti());
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
                bgl.baglanti().Close();
                Temizle();
            }
            else
            {
                MessageBox.Show("Değerler Boş Geçilemez", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
