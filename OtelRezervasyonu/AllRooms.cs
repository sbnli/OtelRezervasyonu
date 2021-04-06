using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OtelRezervasyonu
{
    public class AllRooms
    {
        public static DataSet AllRoom(string roomType)
        {

            var sqlCommand = "select * from Room ";
            return VeritabaniIslemleri.SelectSogusuCalistir(sqlCommand);
        }
        public static DataSet Price(string roomType)
        {

            var sqlCommand = "select * from Price ";
            return VeritabaniIslemleri.SelectSogusuCalistir(sqlCommand);
        }
    }
}