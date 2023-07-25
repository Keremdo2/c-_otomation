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
using System.Configuration;


namespace Hacettepe_Telekom
{
    public partial class FrmFaturalar : Form
    {
        public FrmFaturalar()
        {
            InitializeComponent();
        }
        SqlConn bgl = new SqlConn();

        public static object ConfigurationManager { get; private set; }

        private void FrmFaturalar_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hacettepe_TelekomDataSet2.tbl_faturalar' table. You can move, or remove it, as needed.
            this.tbl_faturalarTableAdapter.Fill(this.hacettepe_TelekomDataSet2.tbl_faturalar);
            SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM tbl_faturalar", bgl.baglanti());
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            bgl.baglanti().Close();
        }

        private void btnPersonLoginComeBack_Click(object sender, EventArgs e)
        {
            FrmPersonUI frmPersonUI = new FrmPersonUI();
            frmPersonUI.Show();
            this.Close();
        }
    }
}
