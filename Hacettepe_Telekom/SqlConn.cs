using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace Hacettepe_Telekom
{
    internal class SqlConn
    {
        

        public SqlConnection baglanti()
        {
            string mainconn = ConfigurationManager.ConnectionStrings["Hacettepe_Telekom.Properties.Settings.Hacettepe_TelekomConnectionString"].ConnectionString;
            SqlConnection sqlConnection = new SqlConnection(mainconn);
            sqlConnection.Open();
            return sqlConnection;

            //SqlConnection conn = new SqlConnection("Data Source=KEREM_YEREBAKAN;Initial Catalog=Hacettepe_Telekom;Integrated Security=True");
            //conn.Open();
            //return conn;
        }
       
    }
    

}
