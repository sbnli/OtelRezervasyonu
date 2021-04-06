using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace OtelRezervasyonu
{
    public class VeritabaniIslemleri
    {
        private static SqlConnection Connection()
        {
            return new SqlConnection(@"Data Source=LAPTOP-7CGER5IK;Initial Catalog=OTEL;Integrated Security=True");
        }

        public static DataSet SelectSogusuCalistir(SqlCommand sqlCommand)
        {
            var ds = new DataSet();
            sqlCommand.Connection = Connection();
            SqlDataAdapter da = new SqlDataAdapter(sqlCommand);
            da.Fill(ds);
            return ds;
        }

        public static DataSet SelectSogusuCalistir(string sqlSorgu)
        {
            var ds = new DataSet();
            SqlCommand sqlCommand = new SqlCommand(sqlSorgu);
            sqlCommand.Connection = Connection();
            SqlDataAdapter da = new SqlDataAdapter(sqlCommand);
            da.Fill(ds);
            return ds;
        }

        public static void kaydet(SqlCommand cmd)
        {
            cmd.Connection = Connection();
            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
        }

        public static void kaydet(string sqlSorgu)
        {
            SqlCommand sqlCommand = new SqlCommand(sqlSorgu);
            sqlCommand.Connection = Connection();
            sqlCommand.Connection.Open();
            sqlCommand.ExecuteNonQuery();
            sqlCommand.Connection.Close();
        }
        public static void Sil(SqlCommand sqlCommand)
        {
            sqlCommand.Connection = Connection();
            sqlCommand.Connection.Open();
            sqlCommand.ExecuteNonQuery();
            sqlCommand.Connection.Close();
        }
        public static void Sil(string sqlSorgu)
        {
            SqlCommand sqlCommand = new SqlCommand(sqlSorgu);
            sqlCommand.Connection = Connection();
            sqlCommand.Connection.Open();
            sqlCommand.ExecuteNonQuery();
            sqlCommand.Connection.Close();
        }
        public static void Update(string sqlSorgu)
        {
            SqlCommand sqlCommand = new SqlCommand(sqlSorgu);
            sqlCommand.Connection = Connection();
            sqlCommand.Connection.Open();
            sqlCommand.ExecuteNonQuery();
            sqlCommand.Connection.Close();
        }
        public static void Update(SqlCommand sqlCommand)
        {
            sqlCommand.Connection = Connection();
            sqlCommand.Connection.Open();
            sqlCommand.ExecuteNonQuery();
            sqlCommand.Connection.Close();
        }
    }
}
