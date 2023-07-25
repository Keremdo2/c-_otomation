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
    public partial class FrmPersonLogin : Form
    {
        public FrmPersonLogin()
        {
            InitializeComponent();
        }
        SqlConn bgl = new SqlConn();
        private void btnPersonLogin_Click(object sender, EventArgs e)
        {
            //Giriş Veri tabanı kontrolü
            SqlCommand command = new SqlCommand("Select * From tbl_personeller where Personel_kadi=@p1 and personel_sifre=@p2 and personel_bolum='magaza'",bgl.baglanti());
            command.Parameters.AddWithValue("@p1", txtPersonLoginNick.Text);
            command.Parameters.AddWithValue("@p2", txtPersonLoginPass.Text);
            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                FrmPersonUI frmPersonUI = new FrmPersonUI();
                frmPersonUI.Show();
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
