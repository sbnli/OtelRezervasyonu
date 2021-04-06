<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PersonnelLogin.aspx.cs" Inherits="OtelRezervasyonu.PersonnelLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">

        .auto-style4 {
            height: 77px;
        }
    
        .auto-style1 {
            width: 100%;
            height: 463px;
        }
        .auto-style2 {
            width: 94px;
        }
        .auto-style3 {
            width: 13px;
        }
        .auto-style5 {
        width: 94px;
        height: 83px;
    }
    .auto-style6 {
        width: 13px;
        height: 83px;
    }
    .auto-style7 {
        height: 83px;
    }
    </style>
</head>
<body>
    <form id="form2" runat="server" class="auto-style4">
        <table class="auto-style1" style="background-image: url('http://localhost:57121/Resimler/giris.jpg')">
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
                <td class="auto-style5"></td>
                <td class="auto-style6"></td>
                <td class="auto-style7">
                    <asp:Label ID="Label1" runat="server" Text="Label" Visible="False"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style3">&nbsp;</td>
            </tr>
        </table>
    </form>
</body>
</html>
