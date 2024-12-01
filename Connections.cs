using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Veteriner_web
{
    public class Connections
    {
        public SqlConnection connect()
        {
            SqlConnection sqlConnection = new SqlConnection("Data Source=DESKTOP-U1O92AP\\MSSQLSERVER01;Initial Catalog=Db_veteriner;Integrated Security=True");
            sqlConnection.Open();
            return sqlConnection;

        }
    }
}
