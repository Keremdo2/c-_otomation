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

namespace Hacettepe_Telekom
{
    public partial class FrmPersonStok : Form
    {
        public FrmPersonStok()
        {
            InitializeComponent();
        }

        public void Temizle()
        {
            txtstokid.Text = "";
            cmbStokMarka.Text = "";
            cmbStokModel.Text = "";
            cmbStokHafiza.Text = "";
            cmbStokRam.Text = "";
            txtStokFiyat.Text = "";
            RtxtStokAciklama.Text = "";
            cmbStokMarka.Focus();

        }
        SqlConn bgl = new SqlConn();
        private void FrmPersonStok_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hacettepe_TelekomDataSet1.tbl_vitrin' table. You can move, or remove it, as needed.
           // this.tbl_vitrinTableAdapter.Fill(this.hacettepe_TelekomDataSet1.tbl_vitrin);
            // sql den comboboxa markaları çekme
            SqlCommand command = new SqlCommand("select * from tbl_telefonmarkalar",bgl.baglanti());
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                cmbStokMarka.Items.Add(reader["marka_ad"].ToString());
            }
            reader.Close();
            bgl.baglanti().Close();

            // sql den comboboxa hafızaları çekme
            SqlCommand command2 = new SqlCommand("select * from tbl_hafizalar", bgl.baglanti());
            SqlDataReader reader2 = command2.ExecuteReader();
            while (reader2.Read())
            {
                cmbStokHafiza.Items.Add(reader2["urun_hafiza"].ToString());
            }
            reader2.Close();
            bgl.baglanti().Close();

            // sql den comboboxa ramleri çekme
            SqlCommand command3 = new SqlCommand("select * from tbl_ramler", bgl.baglanti());
            SqlDataReader reader3 = command3.ExecuteReader();
            while (reader3.Read())
            {
                cmbStokRam.Items.Add(reader3["urun_ram"].ToString());
            }
            reader3.Close();
            bgl.baglanti().Close();


            this.tbl_urunlerTableAdapter.Fill(this.hacettepe_TelekomDataSet.tbl_urunler);

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // gridden veri çekme
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txtstokid.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            cmbStokMarka.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            cmbStokModel.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            cmbStokHafiza.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            cmbStokRam.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            txtStokFiyat.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            RtxtStokAciklama.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
        }

        private void cmbStokMarka_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("select model_ad from tbl_modeller where marka_id=@p1",bgl.baglanti());
            command.Parameters.AddWithValue("@p1", cmbStokMarka.SelectedIndex);
            SqlDataReader reader = command.ExecuteReader();
            while(reader.Read())
            {
                cmbStokModel.Items.Add(reader[0]);
            }
            bgl.baglanti().Close(); 
        }

        private void btnStokAdd_Click(object sender, EventArgs e)
        {
            // veri tabanına manuel veri ekleme 
            if(cmbStokMarka.Text != "" && cmbStokModel.Text != "" && cmbStokHafiza.Text !="" && cmbStokRam.Text !="" && txtStokFiyat.Text != "") { 
            SqlCommand command = new SqlCommand("insert into tbl_urunler (urun_marka,urun_model,urun_hafiza,urun_ram,urun_fiyat,urun_aciklama) values (@p1,@p2,@p3,@p4,@p5,@p6)", bgl.baglanti());
            command.Parameters.AddWithValue("@p1", cmbStokMarka.Text);
            command.Parameters.AddWithValue("@p2", cmbStokModel.Text);
            command.Parameters.AddWithValue("@p3", cmbStokHafiza.Text);
            command.Parameters.AddWithValue("@p4", cmbStokRam.Text);
            command.Parameters.AddWithValue("@p5", txtStokFiyat.Text);
            command.Parameters.AddWithValue("@p6", RtxtStokAciklama.Text);
            command.ExecuteNonQuery();
            MessageBox.Show("Ürün Stoklara Kaydedildi","Bilgi",MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Değerler Boş Girilemez!!","UYARI!!",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

            //DataGridView i güncelleme
            SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM tbl_urunler", bgl.baglanti());
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            bgl.baglanti().Close();
            Temizle();
        }

        private void btnStokDelete_Click(object sender, EventArgs e)
        {
            //veri silme
            SqlCommand command = new SqlCommand("delete from tbl_urunler where urun_id=@p1",bgl.baglanti());
            command.Parameters.AddWithValue("@p1", txtstokid.Text);
            command.ExecuteNonQuery();
            MessageBox.Show("Ürün Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //datagridviewv yenileme
            SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM tbl_urunler", bgl.baglanti());
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            bgl.baglanti().Close();
            Temizle();
        }

        private void btnStokVitrin_Click(object sender, EventArgs e)
        {
            //vitrin tablosuna veri gönderme
            if(cmbStokMarka.Text != "" && cmbStokModel.Text != "" && cmbStokHafiza.Text != "" && cmbStokRam.Text != "" && txtStokFiyat.Text != "")
            { 
            SqlCommand command = new SqlCommand("insert into tbl_vitrin (urun_marka,urun_model,urun_hafiza,urun_ram,urun_fiyat,urun_aciklama) values (@p1,@p2,@p3,@p4,@p5,@p6)", bgl.baglanti());
            command.Parameters.AddWithValue("@p1", cmbStokMarka.Text);
            command.Parameters.AddWithValue("@p2", cmbStokModel.Text);
            command.Parameters.AddWithValue("@p3", cmbStokHafiza.Text);
            command.Parameters.AddWithValue("@p4", cmbStokRam.Text);
            command.Parameters.AddWithValue("@p5", txtStokFiyat.Text);
            command.Parameters.AddWithValue("@p6", RtxtStokAciklama.Text);
            command.ExecuteNonQuery();
            MessageBox.Show("Ürün Vitrine Çıkarıldı","Bilgi",MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Değerler Boş Girilemez!!", "UYARI!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //delete
            SqlCommand command2 = new SqlCommand("delete from tbl_urunler where urun_id=@p1", bgl.baglanti());
            command2.Parameters.AddWithValue("@p1", txtstokid.Text);
            command2.ExecuteNonQuery();
            
            //datagridview yenileme
            SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM tbl_urunler", bgl.baglanti());
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            bgl.baglanti().Close();
            Temizle();

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            //veri güncelleme
            SqlCommand command = new SqlCommand("update tbl_urunler set urun_marka=@p1,urun_model=@p2,urun_hafiza=@p3,urun_ram=@p4,urun_fiyat=@p5,urun_aciklama=@p6 where urun_id=@p7",bgl.baglanti());
            command.Parameters.AddWithValue("@p1", cmbStokMarka.Text);
            command.Parameters.AddWithValue("@p2", cmbStokModel.Text);
            command.Parameters.AddWithValue("@p3", cmbStokHafiza.Text);
            command.Parameters.AddWithValue("@p4", cmbStokRam.Text);
            command.Parameters.AddWithValue("@p5", txtStokFiyat.Text);
            command.Parameters.AddWithValue("@p6", RtxtStokAciklama.Text);
            command.Parameters.AddWithValue("@p7", txtstokid.Text);
            command.ExecuteNonQuery();
            MessageBox.Show("Ürün Bilgisi Güncellendi","Bilgi",MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            //data grid yenileme
            SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM tbl_urunler", bgl.baglanti());
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            bgl.baglanti().Close();
            Temizle();
        }

        private void btnStokGeri_Click(object sender, EventArgs e)
        {
            FrmPersonUI frmPersonUI = new FrmPersonUI();
            frmPersonUI.Show();
            this.Close();
        }
    }
}
