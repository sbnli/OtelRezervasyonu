<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ControlRoom.aspx.cs" Inherits="OtelRezervasyonu.ControlRoom" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 25px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table border="1" class="auto-style10">
        <tr>
             <td class="auto-style1">Reservation No </td>
                    <td class="auto-style1">Room No</td>
                    <td class="auto-style1">Room Type </td>
            
                    <td class="auto-style1">Check-in</td>
                    <td class="auto-style1">Check-out</td>

                    <td class="auto-style1">Edit</td>
                    <td class="auto-style1">Delete</td>
                </tr>
        <asp:Repeater ID="Repeater1" runat="server">
            <ItemTemplate>
                <tr>
                     <td><%#Eval("reservationID") %></td>
                    <td><%#Eval("roomID") %></td>
                    
                    <td><%#Eval("roomType") %></td>
                    <td><%#Eval("checkin") %></td>
                     <td><%#Eval("checkout") %></td>
                   
                    <td><a href="RoomEdit.aspx">Edit</a></td>
                    <td><a href="RoomDelete.aspx">Delete</a></td>
                </tr>
            </ItemTemplate>
        </asp:Repeater>

    </table>
        </div>
    </form>
</body>
</html>
