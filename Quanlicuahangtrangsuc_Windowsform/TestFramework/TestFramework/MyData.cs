using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace TestFramework
{
    class MyData
    {
        SqlConnection con = new SqlConnection(@"Data Source=YELLOWC;Initial Catalog=DiamondGroup;Integrated Security=True");
        public SqlConnection GetConnection
        {
            get
            {
                return con;
            }
        }
        public void openConnection()
        {
            if ((con.State == System.Data.ConnectionState.Closed))
            {
                con.Open();
            }
        }
        public void closeConnection()
        {
            if ((con.State == System.Data.ConnectionState.Open))
            {
                con.Close();
            }
        }
    }
}
