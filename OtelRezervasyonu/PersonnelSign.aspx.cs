using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OtelRezervasyonu
{
    public partial class PersonnelSign : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btkaydet_Click(object sender, EventArgs e)
        {
            var cinsiyet = Convert.ToString((DropDownList1.SelectedValue));
            {
                if(txtUserName.Text!=null)
                {
                    if ((YoneticiKullaniciGirisleri.PersonnelContol(txtUserName.Text) == false))
                    {
                        YoneticiKullaniciGirisleri.personnelSign(txtUserName.Text, txtPassword.Text, txtTC.Text, txtName.Text, txtSurname.Text, txtAddress.Text, txtPhoneNumber.Text, cinsiyet);
                        Response.Redirect("PersonnelLogin.aspx");
                    }
                    else
                    {
                        lblerr.Visible = true;
                        lblerr.Text = "This room is not available!";
                    }

                   
                   
                }
            else
                {
                    lblerr.Visible = true;
                    lblerr.Text = "There is an empty space!";
                }
            }
        }
    }
}