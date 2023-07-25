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
    public partial class FrmPersonNewPerson : Form
    {
        public FrmPersonNewPerson()
        {
            InitializeComponent();
        }
        SqlConn bgl = new SqlConn();
        public void Temizle()
        {
            txtNewPersonName.Text = "";
            txtNewPersonSurName.Text = "";
            txtNewPersonPass.Text = "";
            txtNewPersonPassAgain.Text = "";
            txtNewPersonNickName.Text = "";
            txtNewPersonPayed.Text = "";
            cmbNewPersonBirim.Text = "";
            mtxtNewPersonTC.Text = "";
            mtxtNewPersonTel.Text = "";
            txtNewPersonName.Focus();
        }
        private void btnYeniPersonGeri_Click(object sender, EventArgs e)
        {
            FrmPersonUI frmPersonUI = new FrmPersonUI();
            frmPersonUI.Show();
            this.Close();
        }
        private void FrmPersonNewPerson_Load(object sender, EventArgs e)
        {
            //comboboxa bölüm çekme
            SqlCommand command = new SqlCommand("select * from tbl_bolumler", bgl.baglanti());
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                cmbNewPersonBirim.Items.Add(reader["bolum_adi"].ToString());
            }
            reader.Close();
            bgl.baglanti().Close();
        }
        private void btnNewPersonSave_Click(object sender, EventArgs e)
        {
            if (Convert.ToString(txtNewPersonName.Text) !="" && Convert.ToString(txtNewPersonSurName.Text)  != "" && Convert.ToString(txtNewPersonPass.Text)  != "" && Convert.ToString(txtNewPersonPayed.Text)  != "" && Convert.ToString(txtNewPersonNickName.Text)  != "" && Convert.ToString(mtxtNewPersonTC.Text)  != "" && Convert.ToString(mtxtNewPersonTel.Text)  != "" && Convert.ToString(cmbNewPersonBirim.Text) !="" )
            {
                if (txtNewPersonPass.Text == txtNewPersonPassAgain.Text)
                {
                    SqlCommand command = new SqlCommand("insert into tbl_personeller (personel_ad,personel_soyad,personel_sifre,personel_maas,Personel_kadi,Personel_TC,Personel_Telefon,personel_bolum) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8)", bgl.baglanti());
                    command.Parameters.AddWithValue("@p1", txtNewPersonName.Text);
                    command.Parameters.AddWithValue("@p2", txtNewPersonSurName.Text);
                    command.Parameters.AddWithValue("@p3", txtNewPersonPass.Text);
                    command.Parameters.AddWithValue("@p4", txtNewPersonPayed.Text);
                    command.Parameters.AddWithValue("@p5", txtNewPersonNickName.Text);
                    command.Parameters.AddWithValue("@p6", mtxtNewPersonTC.Text);
                    command.Parameters.AddWithValue("@p7", mtxtNewPersonTel.Text);
                    command.Parameters.AddWithValue("@p8", cmbNewPersonBirim.Text);
                    command.ExecuteNonQuery();
                    bgl.baglanti().Close();

                    MessageBox.Show("Personel Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Girilen Şifreler Birbiri ile Uyuşmadı", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Değerler Boş Geçilemez!!", "UYARI!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            Temizle();
        }

        
    }
}
