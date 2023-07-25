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
    public partial class FrmPersonUI : Form
    {
        public FrmPersonUI()
        {
            InitializeComponent();
        }
        SqlConn bgl = new SqlConn();
        private void btnFrmPersonStok_Click(object sender, EventArgs e)
        {
            FrmPersonStok frm = new FrmPersonStok();
            frm.Show();
            this.Hide();
        }

        private void btnFrmPersonVitrin_Click(object sender, EventArgs e)
        {
            FrmPersonVitrin frm = new FrmPersonVitrin();
            frm.Show();
            this.Hide();
        }

        private void btnFrmPersonSatinal_Click(object sender, EventArgs e)
        {
            FrmPersonBuy frm = new FrmPersonBuy();
            frm.Show();
            this.Hide();
        }

        private void btnFrmPersonCikisyap_Click(object sender, EventArgs e)
        {
            FrmLogin frm = new FrmLogin();
            frm.Show();
            this.Close();
        }

        private void btnFrmPersonYeniPerson_Click(object sender, EventArgs e)
        {
            FrmPersonNewPerson frm = new FrmPersonNewPerson();
            frm.Show();
            this.Close();
        }

        private void btnFrmPersonCikar_Click(object sender, EventArgs e)
        {
            FrmFaturalar frm = new FrmFaturalar();  
            frm.Show();
            this.Close();
        }
    }
}
