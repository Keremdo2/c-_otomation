using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hacettepe_Telekom
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnFrmLogin_Click(object sender, EventArgs e)
        {
            FrmPersonLogin frmPersonLogin = new FrmPersonLogin();
            frmPersonLogin.Show();
            this.Hide();
        }

        private void btnMudurGiris_Click(object sender, EventArgs e)
        {
            FrmMudurGiris frmMudurGiris = new FrmMudurGiris();
            frmMudurGiris.Show();
            this.Hide();
        }
    }
}
