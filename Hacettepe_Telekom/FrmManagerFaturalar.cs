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
    public partial class FrmManagerFaturalar : Form
    {
        public FrmManagerFaturalar()
        {
            InitializeComponent();
        }
        SqlConn bgl = new SqlConn();

        public void Temizle()
        {
            txtFaturaId.Text = "";
            mtxtFaturaTC.Text = "";
            txtFaturaTutar.Text = "";
            mtxtFaturaTarih.Text = "";
            mtxtFaturaTel.Text = "";
            mtxtFaturaTC.Focus();
        }
        private void FrmManagerFaturalar_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hacettepe_TelekomDataSet4.tbl_faturalar' table. You can move, or remove it, as needed.
            this.tbl_faturalarTableAdapter.Fill(this.hacettepe_TelekomDataSet4.tbl_faturalar);

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if(txtFaturaId.Text != "" && mtxtFaturaTC.Text != "" && txtFaturaTutar.Text != "" && mtxtFaturaTarih.Text != "" && mtxtFaturaTel.Text != "")
            {
                SqlCommand command = new SqlCommand("update tbl_faturalar set fatura_TC=@p1,fatura_bedel=@p2,fatura_tarih=@p3,fatura_tel=@p4 where fatura_id=@p5", bgl.baglanti());
                command.Parameters.AddWithValue("@p1", mtxtFaturaTC.Text);
                command.Parameters.AddWithValue("@p2", txtFaturaTutar.Text);
                command.Parameters.AddWithValue("@p3", mtxtFaturaTarih.Text);
                command.Parameters.AddWithValue("@p4", mtxtFaturaTel.Text);
                command.Parameters.AddWithValue("@p5", txtFaturaId.Text);
                command.ExecuteNonQuery();
                MessageBox.Show("Fatura Bilgileri Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                bgl.baglanti().Close();

                SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM tbl_faturalar", bgl.baglanti());
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
                bgl.baglanti().Close();
            }
            else
            {
                MessageBox.Show("Değerler Boş Girilemez", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            Temizle();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // gridden veri çekme
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txtFaturaId.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            mtxtFaturaTC.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txtFaturaTutar.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            mtxtFaturaTarih.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            mtxtFaturaTel.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();

        }

        private void btnGeriGel_Click(object sender, EventArgs e)
        {
            FrmManagerUI frmManagerUI = new FrmManagerUI();
            frmManagerUI.Show();
            this.Close();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (txtFaturaId.Text != "" && mtxtFaturaTC.Text != "" && txtFaturaTutar.Text != "" && mtxtFaturaTarih.Text != "" && mtxtFaturaTel.Text != "")
            {
                SqlCommand command = new SqlCommand("delete from tbl_faturalar where fatura_id=@p1", bgl.baglanti());
                command.Parameters.AddWithValue("@p1", txtFaturaId.Text);
                command.ExecuteNonQuery();
                MessageBox.Show("Fatura Bİlgisi Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                bgl.baglanti().Close();

                SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM tbl_faturalar", bgl.baglanti());
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
                bgl.baglanti().Close();
            }
            else
            {
                MessageBox.Show("Değerler Boş Girilemez", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
                
            Temizle();
        }
    }
}
