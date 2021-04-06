using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OtelRezervasyonu
{
    public partial class RoomEdit : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var roomType = Convert.ToString((ddIRoomType.SelectedValue));
            if (!Page.IsPostBack)
            {
                ddIRoomType.DataTextField = "roomType";
                ddIRoomType.DataValueField = "roomID";
                ddIRoomType.DataSource = AllRooms.AllRoom(roomType);
                ddIRoomType.DataBind();
            }
            var priceType = Convert.ToString((ddIRoomPrice.SelectedValue));
            if (!Page.IsPostBack)
            {
                ddIRoomPrice.DataTextField = "priceType";
                ddIRoomPrice.DataValueField = "priceID";
                ddIRoomPrice.DataSource = AllRooms.Price(priceType);
                ddIRoomPrice.DataBind();
            }
        }

        protected void btnEdit_Click(object sender, EventArgs e)
        {
            var roomID = int.Parse(ddIRoomType.SelectedValue.ToString());
            var priceID = int.Parse(ddIRoomPrice.SelectedValue.ToString());

            if ((txtCheckin.Text != null && txtCheckout.Text != null))
            {
                if ((YoneticiKullaniciGirisleri.reservationUpdateContol(txtCheckin.Text, txtCheckout.Text, roomID, priceID)) == false)
                {
                    YoneticiKullaniciGirisleri.reservationUpdateContol(txtCheckin.Text, txtCheckout.Text, roomID, priceID);
                }
                else
                {
                    lblAvailable.Visible = true;
                    lblAvailable.Text = "This room is not available!";
                }
            }
            else
            {
                lblEdit.Visible = true;
                lblEdit.Text = "There is an empty space!";
            }
        }
        }
    
}
