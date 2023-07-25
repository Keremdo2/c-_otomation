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
    public partial class FrmMudurGiris : Form
    {
        public FrmMudurGiris()
        {
            InitializeComponent();
        }
        SqlConn bgl = new SqlConn();
        private void btnMudur_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("Select * From tbl_personeller where Personel_kadi=@p1 and personel_sifre=@p2 and personel_bolum='idari'", bgl.baglanti());
            command.Parameters.AddWithValue("@p1", txtMudurKadi.Text);
            command.Parameters.AddWithValue("@p2", txtMudurSifre.Text);
            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                FrmManagerUI frmManagerUI = new FrmManagerUI();
                frmManagerUI.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Kullanıcı Adı veya Şifre Hatalı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            bgl.baglanti().Close();
        }

        private void btnPersonLoginComeBack_Click(object sender, EventArgs e)
        {
            FrmLogin frmLogin = new FrmLogin();
            frmLogin.Show();
            this.Close();
        }
    }
}
