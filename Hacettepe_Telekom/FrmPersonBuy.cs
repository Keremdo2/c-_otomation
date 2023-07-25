using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace Hacettepe_Telekom
{
    public partial class FrmPersonBuy : Form
    {
        public FrmPersonBuy()
        {
            InitializeComponent();
        }
        SqlConn bgl = new SqlConn();
        public void Temizle()
        {
            txtBuyId.Text = "";
            cmbBuyMarka.Text = "";
            cmbBuyModel.Text = "";
            cmbBuyHafiza.Text = "";
            cmbBuyRam.Text = "";
            txtBuyFiyat.Text = "";
            rtxtBuyAciklama.Text = "";
            cmbBuyMarka.Focus();
        }
        private void FrmPersonBuy_Load(object sender, EventArgs e)
        {
            // sql den comboboxa markaları çekme
            SqlCommand command = new SqlCommand("select * from tbl_telefonmarkalar", bgl.baglanti());
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                cmbBuyMarka.Items.Add(reader["marka_ad"].ToString());
            }
            reader.Close();
            bgl.baglanti().Close();

            // sql den comboboxa hafızaları çekme
            SqlCommand command2 = new SqlCommand("select * from tbl_hafizalar", bgl.baglanti());
            SqlDataReader reader2 = command2.ExecuteReader();
            while (reader2.Read())
            {
                cmbBuyHafiza.Items.Add(reader2["urun_hafiza"].ToString());
            }
            reader2.Close();
            bgl.baglanti().Close();

            // sql den comboboxa ramleri çekme
            SqlCommand command3 = new SqlCommand("select * from tbl_ramler", bgl.baglanti());
            SqlDataReader reader3 = command3.ExecuteReader();
            while (reader3.Read())
            {
                cmbBuyRam.Items.Add(reader3["urun_ram"].ToString());
            }
            reader3.Close();
            bgl.baglanti().Close();

            // TODO: This line of code loads data into the 'hacettepe_TelekomDataSet.tbl_urunler' table. You can move, or remove it, as needed.         
            this.tbl_urunlerTableAdapter.Fill(this.hacettepe_TelekomDataSet.tbl_urunler);

        }

        private void btnStokGeri_Click(object sender, EventArgs e)
        {
            FrmPersonUI frmPersonUI = new FrmPersonUI();
            frmPersonUI.Show();
            this.Close();
        }



        private void btnBuyBuy_Click(object sender, EventArgs e)
        {
            if (cmbBuyMarka.Text != "" && cmbBuyModel.Text != "" && cmbBuyHafiza.Text != "" && cmbBuyRam.Text != "" && txtBuyFiyat.Text != "")
            {
                SqlCommand command = new SqlCommand("insert into tbl_urunler (urun_marka,urun_model,urun_hafiza,urun_ram,urun_fiyat,urun_aciklama) values (@p1,@p2,@p3,@p4,@p5,@p6)", bgl.baglanti());
                command.Parameters.AddWithValue("@p1", cmbBuyMarka.Text);
                command.Parameters.AddWithValue("@p2", cmbBuyModel.Text);
                command.Parameters.AddWithValue("@p3", cmbBuyHafiza.Text);
                command.Parameters.AddWithValue("@p4", cmbBuyRam.Text);
                command.Parameters.AddWithValue("@p5", txtBuyFiyat.Text);
                command.Parameters.AddWithValue("@p6", rtxtBuyAciklama.Text);
                command.ExecuteNonQuery();
                MessageBox.Show("Ürün Satın Alındı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Belge oluşturmak için gerekli değişkenler
                string klasorYolu = @"C:\Users\kerem\OneDrive\Masaüstü\görsel3\Hacettepe_Telekom\satin_alim_Fatura";
                string fileName = "Fatura_" + txtBuyId.Text + DateTime.Now.ToString("dd_MM_yyyy_HH_mm_ss") + ".txt";
                string filePath = Path.Combine(klasorYolu, fileName);

                // Belge içeriği
                string documentContent = "ÜRÜN : " + cmbBuyMarka.Text + " " + cmbBuyModel.Text + " İşlem Tarihi :" + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");

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

                SqlCommand command2 = new SqlCommand("insert into tbl_faturalar (fatura_TC,fatura_bedel,fatura_tarih) values (@p1,@p2,@p3)",bgl.baglanti());
                command2.Parameters.AddWithValue("@p1", txtBuyId.Text);
                command2.Parameters.AddWithValue("@p2", txtBuyFiyat.Text);
                command2.Parameters.AddWithValue("@p3", DateTime.Now);
                command2.ExecuteNonQuery();
                bgl.baglanti().Close();
                
            }
            else
            {
                MessageBox.Show("Değerler Boş Girilemez!!", "UYARI!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            //grid yenileme
            SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM tbl_urunler", bgl.baglanti());
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            bgl.baglanti().Close();
            Temizle();


        }

        private void cmbBuyMarka_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Markaya göre Model Getirme
            SqlCommand command = new SqlCommand("select model_ad from tbl_modeller where marka_id=@p1", bgl.baglanti());
            command.Parameters.AddWithValue("@p1", cmbBuyMarka.SelectedIndex);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                cmbBuyModel.Items.Add(reader[0]);
            }
            bgl.baglanti().Close();
        }
    }
}
