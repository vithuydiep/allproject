﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Day01
{
    class MyDB
    {
        SqlConnection con = new SqlConnection(@"Data Source=YELLOWC;Initial Catalog=LoginDB;Integrated Security=True;Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;Encrypt=False;TrustServerCertificate=True");
        public SqlConnection getConnection
        {
            get { return con; }
        }
        public void openConnection()
        {
            if (con.State == ConnectionState.Closed)
                con.Open();

        }
        public void closeConnection()
        {
            if (con.State == ConnectionState.Open)
                con.Close();
        }
    }
}
