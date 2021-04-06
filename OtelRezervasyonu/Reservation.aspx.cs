using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OtelRezervasyonu
{
    public partial class Reservation : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            var roomType = Convert.ToString((DropDownList1.SelectedValue));
            if (!Page.IsPostBack)
            {
                DropDownList1.DataTextField = "roomType";
                DropDownList1.DataValueField = "roomID";
                DropDownList1.DataSource = AllRooms.AllRoom(roomType);
                DropDownList1.DataBind();
            }
            var priceType = Convert.ToString((DropDownList2.SelectedValue));
            if (!Page.IsPostBack)
            {
                DropDownList2.DataTextField = "priceType";
                DropDownList2.DataValueField = "priceID";
                DropDownList2.DataSource = AllRooms.Price(priceType);
                DropDownList2.DataBind();
            }
        }
        protected void btnKaydet_Click(object sender, EventArgs e)
        {
            {
                var roomID = int.Parse(DropDownList1.SelectedValue.ToString());
                var priceID = int.Parse(DropDownList2.SelectedValue.ToString());

                if ((txtCheckin.Text != null && txtCheckout.Text != null))
                {
                    if ((YoneticiKullaniciGirisleri.reservationContol(txtCheckin.Text, txtCheckout.Text, roomID)) == false)
                    {
                        YoneticiKullaniciGirisleri.Reservation(txtCheckin.Text, txtCheckout.Text, roomID, priceID);
                    }
                    else
                    {
                    lblRoomAvailable.Visible = true;
                        lblRoomAvailable.Text = "This room is not available!";
                    }
                }
                else
                {
                    lblRoomAvailable.Visible = true;
                    lblRoomAvailable.Text = "There is an empty space!";
                }
            }
        }
    }
}