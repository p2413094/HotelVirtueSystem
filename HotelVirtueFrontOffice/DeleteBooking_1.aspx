<%@ Page Language="C#" AutoEventWireup="true" CodeFile="DeleteBooking_1.aspx.cs" Inherits="DeleteBookingLine_1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Delete booking</title>
    <link rel="stylesheet" href="StyleSheet.css" />
</head>
<body class="body">
    <form runat="server">
        <div class="logo">
            Hotel Virtue           
        </div>

        <div>
            <ul class="ul" >
                <li><span style="font-size:30px;cursor:pointer" onclick="openNav()">&#9776; MENU</span></li>
                <li class="signInRight"><a href="ViewBooking_1.aspx">SIGN IN/ REGISTER</a></li>
            </ul>
        </div>
        
        <div id="mySidenav" class="sidenav">
          <a href="javascript:void(0)" class="closebtn" onclick="closeNav()">&times;</a>
          <a href="#">SEARCH FOR HOTEL</a>
          <a href="#">OFFERS</a>
          <a href="#">CONTACT DETAILS</a>
          <a href="#">OTHER OPTION HERE</a>
        </div>

        <script>
            function openNav() {
                document.getElementById("mySidenav").style.width = "30%";
            }

            function closeNav() {
                document.getElementById("mySidenav").style.width = "0";
            }
        </script>

        <br />
        <div>
            <asp:HyperLink ID="hyplnkReturnToBookings" CssClass="returnText" NavigateUrl="~/ViewBooking_1.aspx" runat="server">Return to bookings</asp:HyperLink>
        </div>

        <br />
        <br />
        <asp:Panel ID="pnlBooking" CssClass="box" runat="server"></asp:Panel>
     </form>
</body>
</html>
