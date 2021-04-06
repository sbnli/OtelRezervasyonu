<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CustomerSign.aspx.cs" Inherits="OtelRezervasyonu.CustomerSign" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">


        .auto-style1 {
            width: 100%;
            height: 421px;
        }
        .auto-style2 {
            width: 277px;
        }
        .auto-style3 {
            width: 16px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <table class="auto-style1" style="background-image: url('http://localhost:57121/Resimler/kayıt.jpg')">
            <tr>
                <td class="auto-style2">User Name</td>
                <td class="auto-style3">:</td>
                <td>
                    <asp:TextBox ID="txtUserName" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Password</td>
                <td class="auto-style3">:</td>
                <td>
                    <asp:TextBox ID="txtPassword" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Name</td>
                <td class="auto-style3">:</td>
                <td>
                    <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Surname</td>
                <td class="auto-style3">:</td>
                <td>
                    <asp:TextBox ID="txtSurname" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">TC Identity</td>
                <td class="auto-style3">:</td>
                <td>
                    <asp:TextBox ID="txtTC" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Phone Number</td>
                <td class="auto-style3">:</td>
                <td>
                    <asp:TextBox ID="txtPhoneNumber" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Gender</td>
                <td class="auto-style3">:</td>
                <td>
                    <asp:DropDownList ID="DropDownList1" runat="server">
                        <asp:ListItem Value="0">Male</asp:ListItem>
                        <asp:ListItem Value="1">Female</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Address</td>
                <td class="auto-style3">:</td>
                <td>
                    <asp:TextBox ID="txtAddress" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style3">&nbsp;</td>
                <td>
                    <asp:Button ID="btkaydet" runat="server" OnClick="btkaydet_Click" Text="Sign Up" />
                </td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style3">&nbsp;</td>
                <td>
                    <asp:Label ID="lblerr" runat="server" ForeColor="#0066CC" Text="Label" Visible="False"></asp:Label>
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
