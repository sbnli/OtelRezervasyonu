using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace OtelRezervasyonu
{
    public class YoneticiKullaniciGirisleri
    {
        private static SqlConnection Connection()
        {
            return new SqlConnection(@"Data Source=LAPTOP-7CGER5IK;Initial Catalog=OTEL;Integrated Security=True");
        }
        public static DataRow personnelLogin(string persUserName, string persPassword)
        {
            var sorgu = "select * from Personnel where personnelUserName='" + persUserName + "' and personnelPassword='" + persPassword + "'";
            var persData = VeritabaniIslemleri.SelectSogusuCalistir(sorgu);
            if (persData.Tables[0].Rows.Count == 1)
            {
                return persData.Tables[0].Rows[0];
            }
            else
            {
                return null;
            }
        }

        public static DataRow CustomerLogin(string custUserName, string custPassword)
        {
            var sorgu = "select * from Customer where customerUserName='" + custUserName + "' and customerPassword='" + custPassword + "'";
            var custData = VeritabaniIslemleri.SelectSogusuCalistir(sorgu);
            if (custData.Tables[0].Rows.Count == 1)
            {
                return custData.Tables[0].Rows[0];
            }
            else
            {
                return null;
            }
        }
        public static void customerSign(string custUserName, string custPassword, string custName, string custSurname, string custTC, string custAddress, string custPhone,string custGender)
        {
            var q = @"INSERT INTO [dbo].[Customer]
           ([customerUserName]
           ,[customerPassword]
           ,[customerTC]
           ,[customerName]
           ,[customerSurname]
           ,[customerAddress]
           ,[customerPhoneNumber]
           ,[customerGender])
     VALUES ('" + custUserName + "','" + custPassword + "','" + custName + "','" + custSurname + "','" + custAddress + "','" + custTC + "','" + custPhone + "','"+custGender+"')";
            VeritabaniIslemleri.kaydet(q);
        }

        public static void personnelSign(string persUserName, string persPassword, string persName, string persSurname, string persTC, string persAddress, string persPhone,string persGender)
        {
            var q = @"INSERT INTO [dbo].[Personnel]
           ([personnelUserName]
           ,[personnelPassword]
           ,[personnelTC]
           ,[personnelName]
           ,[personnelSurname]
           ,[personnelAddress]
           ,[personnelPhoneNumber]
           ,[personnelGender])
     VALUES ('" + persUserName + "','" + persPassword + "','" + persName + "','" + persSurname + "','" + persAddress + "','" + persTC + "','" + persPhone + "','"+persGender+ "')";
            VeritabaniIslemleri.kaydet(q);
        }
      
        public static void Reservation(string checkin, string checkout, int roomID,int priceID)
        {
            var q = @"INSERT INTO [dbo].[Reservation]
           ([checkin]
           ,[checkout]
           ,[roomID]
           ,[priceID])
     VALUES ('" + checkin + "','" + checkout + "','" +roomID+"','"+priceID+"')";
            VeritabaniIslemleri.kaydet(q);
        }
        public static bool reservationContol(string checkin, string checkout, int roomID)
        {

            bool contr = false;
            string sql = "select * from Reservation where checkin ='" + checkin + "' and checkout='" + checkout + "' and roomID='" + roomID + "'";
            SqlCommand sqlCommand = new SqlCommand(sql);
            sqlCommand.Connection = Connection();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlCommand);
            sqlCommand.Connection.Open();
            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet);
            sqlCommand.ExecuteNonQuery();
            sqlCommand.Connection.Close();
            if (dataSet.Tables[0].Rows.Count > 0)
            {
                contr = true;
            }
            return contr;
        }
        public static bool PersonnelContol(string username)
        {

            bool contr = false;
            string sql = "select * from Personnel where personnelUserName ='" + username + "'";
            SqlCommand sqlCommand = new SqlCommand(sql);
            sqlCommand.Connection = Connection();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlCommand);
            sqlCommand.Connection.Open();
            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet);
            sqlCommand.ExecuteNonQuery();
            sqlCommand.Connection.Close();
            if (dataSet.Tables[0].Rows.Count > 0)
            {
                contr = true;
            }
            return contr;
        }
        public static bool CustomerContol(string username)
        {

            bool contr = false;
            string sql = "select * from Customer where customerUserName ='" + username + "'";
            SqlCommand sqlCommand = new SqlCommand(sql);
            sqlCommand.Connection = Connection();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlCommand);
            sqlCommand.Connection.Open();
            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet);
            sqlCommand.ExecuteNonQuery();
            sqlCommand.Connection.Close();
            if (dataSet.Tables[0].Rows.Count > 0)
            {
                contr = true;
            }
            return contr;
        }
        public static void reservationUpdate(string checkin, string checkout, int roomID,int priceID)
        {

            bool contr = false;
            string sql = "update Reservation set roomID='" + roomID+ "',priceID='" + priceID + "' ,checkin ='" + checkin + "', checkout='" + checkout + "'";
            VeritabaniIslemleri.Update(sql);
        }
        
        public static void ReservationDelete(int reservationID)
        {
            string command="delete from Reservation where reservationID='"+reservationID+"'";
            VeritabaniIslemleri.Sil(command);
        }
        public static bool reservationUpdateContol(string checkin, string checkout, int roomID,int priceID)
        {

            bool contr = false;
            string sql = "select * from Reservation where checkin ='" + checkin + "' and checkout='" + checkout + "' and roomID='" + roomID + "' and priceID='" + priceID + "'";
            SqlCommand sqlCommand = new SqlCommand(sql);
            sqlCommand.Connection = Connection();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlCommand);
            sqlCommand.Connection.Open();
            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet);
            sqlCommand.ExecuteNonQuery();
            sqlCommand.Connection.Close();
            if (dataSet.Tables[0].Rows.Count > 0)
            {
                contr = true;
            }
            return contr;
        }

    }
}