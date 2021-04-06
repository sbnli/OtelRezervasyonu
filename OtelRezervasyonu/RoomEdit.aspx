<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RoomEdit.aspx.cs" Inherits="OtelRezervasyonu.RoomEdit" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 26px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1">
    <tr>
        <td class="auto-style3">Check-in</td>
        <td class="auto-style2">:</td>
        <td>
            <asp:TextBox ID="txtCheckin" runat="server" Width="208px" TextMode="Date"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="auto-style3">Check-out</td>
        <td class="auto-style2">:</td>
        <td>
            <asp:TextBox ID="txtCheckout" runat="server" Width="207px" TextMode="Date"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="auto-style1">Room Type</td>
        <td class="auto-style1">:</td>
        <td class="auto-style1">
            <asp:DropDownList ID="ddIRoomType" runat="server" Height="24px" Width="214px">
            </asp:DropDownList>
        </td>
    </tr>
                <tr>
        <td class="auto-style5">Room Price</td>
        <td class="auto-style5">:</td>
        <td class="auto-style5">
            <asp:DropDownList ID="ddIRoomPrice" runat="server" Height="24px" Width="214px">
            </asp:DropDownList>
        </td>
    </tr>
    <tr>
        <td class="auto-style3">Room Available</td>
        <td class="auto-style2">:</td>
        <td>
            <asp:Label ID="lblAvailable" runat="server" Text="Label"></asp:Label>
        </td>
    </tr>
    <tr>
        <td class="auto-style6"></td>
        <td class="auto-style6"></td>
        <td class="auto-style6">
            <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" Text="Edit" />
        </td>
    </tr>
    <tr>
        <td class="auto-style3">&nbsp;</td>
        <td class="auto-style2">&nbsp;</td>
        <td>
            <asp:Label ID="lblEdit" runat="server" ForeColor="#0066FF" Visible="False"></asp:Label>
        </td>
    </tr>
</table>
        </div>
    </form>
</body>
</html>
