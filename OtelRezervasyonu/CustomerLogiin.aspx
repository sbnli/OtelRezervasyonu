<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CustomerLogiin.aspx.cs" Inherits="OtelRezervasyonu.CustomerLogiin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">

        .auto-style1 {
            width: 100%;
            height: 461px;
        }
        .auto-style2 {
            width: 94px;
        }
        .auto-style3 {
            width: 13px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <table class="auto-style1" style="background-image: url('http://localhost:57121/Resimler/giris.jpg'); color: #000000">
            <tr>
                <td class="auto-style2">Kullanıcı Adı</td>
                <td class="auto-style3">:</td>
                <td>
                    <asp:TextBox ID="txtUserName" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Şifre</td>
                <td class="auto-style3">:</td>
                <td>
                    <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style3">&nbsp;</td>
                <td>
                    <asp:Button ID="btnLogin" runat="server" OnClick="btnLogin_Click" Text="Giriş" />
                </td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style3">&nbsp;</td>
                <td>
                    <asp:Label ID="Label1" runat="server" Text="Label" Visible="False"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style3">&nbsp;</td>
                <td><a href="PersonnelLogin.aspx">Personnel Login</a></td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style3">&nbsp;</td>
                <td><a href="CustomerSign.aspx">Customer Sign</a></td>
            </tr>
        </table>
    </form>
</body>
</html>
