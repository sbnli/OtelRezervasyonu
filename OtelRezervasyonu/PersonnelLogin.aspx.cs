using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OtelRezervasyonu
{
    public partial class PersonnelLogin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            var kullanici = YoneticiKullaniciGirisleri.personnelLogin(txtUserName.Text, txtPassword.Text);
            if (kullanici == null)
            {
                //Hatalı Giriş
                Label1.Visible = true;
                Label1.Text = "Kullanıcı Bulunamadı";
            }
            else
            {
                Session["Kullanici"] = kullanici;
                Session["IsAdmin"] = true;
                Response.Redirect("PersonnelPage.aspx");
            }
        }
    }
}