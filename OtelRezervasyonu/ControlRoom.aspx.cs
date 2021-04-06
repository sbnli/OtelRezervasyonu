using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OtelRezervasyonu
{
    public partial class ControlRoom : System.Web.UI.Page
    {
       
        protected void Page_Load(object sender, EventArgs e)
        {
            Repeater1.DataSource = VeritabaniIslemleri.SelectSogusuCalistir("SELECT r.*,a.roomType AS roomType FROM Reservation AS r INNER JOIN Room a ON a.roomID=r.roomID");
            Repeater1.DataBind();
           
        }
       

    }
}