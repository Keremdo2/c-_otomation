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
    public partial class FrmManagerUI : Form
    {
        public FrmManagerUI()
        {
            InitializeComponent();
        }

        private void btnPersoneller_Click(object sender, EventArgs e)
        {
            FrmManagerPersoneller frmManagerPersoneller = new FrmManagerPersoneller();
            frmManagerPersoneller.Show();
            this.Close();
        }

        private void btnFaturalar_Click(object sender, EventArgs e)
        {
            FrmManagerFaturalar frmManagerFaturalar = new FrmManagerFaturalar();    
            frmManagerFaturalar.Show();
            this.Close();
        }

        private void btnFrmPersonCikisyap_Click(object sender, EventArgs e)
        {
            FrmLogin frmLogin = new FrmLogin();
            frmLogin.Show();
            this.Close();

        }
    }
}
