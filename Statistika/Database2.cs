using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Statistika
{
    class Database2
    {
        private static Database2 instance;

        public static Database2 Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Database2();
                }

                return instance;
            }
        }

        public string ConnectionString { get; private set; }

        public SqlConnection Connection { get; private set; }

        private Database2()
        {
            ConnectionString = @"Data Source=31.147.204.119\PISERVER,1433; Initial Catalog=PI20_015_DB; User=PI20_015_User; Password=7}ahR|3+";
            Connection = new SqlConnection(ConnectionString);
            Connection.Open();
        }

        public void CloseConnection()
        {
            if (Connection.State != System.Data.ConnectionState.Closed)
            {
                Connection.Close();
            }
        }

        public SqlDataReader DohvatiDataReader(string sqlUpit)
        {
            SqlCommand command = new SqlCommand(sqlUpit, Connection);
            return command.ExecuteReader();
        }

        public object DohvatiVrijednost(string sqlUpit)
        {
            SqlCommand command = new SqlCommand(sqlUpit, Connection);
            return command.ExecuteScalar();
        }

        public int IzvrsiUpit(string sqlUpit)
        {
            SqlCommand command = new SqlCommand(sqlUpit, Connection);
            return command.ExecuteNonQuery();
        }
    }
}
