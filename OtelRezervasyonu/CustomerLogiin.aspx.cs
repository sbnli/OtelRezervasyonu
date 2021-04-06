using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OtelRezervasyonu
{
    public partial class CustomerLogiin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {

            var customer = YoneticiKullaniciGirisleri.CustomerLogin(txtUserName.Text, txtPassword.Text);
            if (customer == null)
            {
                //Hatalı Giriş
                Label1.Visible = true;
                Label1.Text = "Customer is not found!";
            }
            else
            {
                Session["Customer"] = customer;

                Response.Redirect("Reservation.aspx");
            }
        }
    }
}