<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Reservation.aspx.cs" Inherits="OtelRezervasyonu.Reservation" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">


        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 473px;
            text-align: center;
        }
        .auto-style3 {
            width: 473px;
            text-align: center;
            height: 28px;
        }
        .auto-style4 {
            height: 28px;
        }
        .auto-style5 {
            width: 473px;
            text-align: center;
            height: 23px;
        }
        .auto-style6 {
            height: 23px;
        }
        .auto-style7 {
            width: 473px;
            text-align: center;
            height: 30px;
        }
        .auto-style8 {
            height: 30px;
        }
        .auto-style9 {
            width: 473px;
            text-align: center;
            height: 26px;
        }
        .auto-style10 {
            height: 26px;
        }
        </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <table class="auto-style1">
            <tr>
                <td class="auto-style5">
                    <asp:Label ID="Label1" runat="server" style="text-align: left" Text="Search"></asp:Label>
                </td>
                <td class="auto-style6"></td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="Label2" runat="server" Text="Check-in"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtCheckin" runat="server" TextMode="Date"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">
                    <asp:Label ID="Label3" runat="server" Text="Check out"></asp:Label>
                </td>
                <td class="auto-style4">
                    <asp:TextBox ID="txtCheckout" runat="server" TextMode="Date"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="Label4" runat="server" Text="Room-Type"></asp:Label>
                </td>
                <td>
                    <asp:DropDownList ID="DropDownList1" runat="server">
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td class="auto-style9">
                    <asp:Label ID="Label5" runat="server" Text="Room Price"></asp:Label>
                </td>
                <td class="auto-style10">
                    <asp:DropDownList ID="DropDownList2" runat="server">
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td class="auto-style5">
                    <asp:Label ID="Label8" runat="server" Text="Rooms Available"></asp:Label>
                </td>
                <td class="auto-style6">
                    <asp:Label ID="lblRoomAvailable" runat="server" Text="Label" Visible="False"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style7">
                    &nbsp;</td>
                <td class="auto-style8">
                    <asp:Button ID="btnKaydet" runat="server" OnClick="btnKaydet_Click" Text="Book" />
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
