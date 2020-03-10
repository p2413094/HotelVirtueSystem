<%@ Page Language="C#" AutoEventWireup="true" CodeFile="PayForBooking_Success.aspx.cs" Inherits="PayForBooking_Success" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Pay for booking</title>
    <link rel="stylesheet" = href="StyleSheet.css" />
</head>
<body class="body">
    <form runat="server">
        <div class="logo">
            Hotel Virtue           
        </div>

        <div>
            <ul class="ul" >
                <li><span style="font-size:30px;cursor:pointer" onclick="openNav()">&#9776; MENU</span></li>
                <li class="signInRight"><a href="#">SIGN IN/ REGISTER</a></li>
            </ul>
        </div>     

        <br />
        <div>
            <asp:HyperLink ID="hyplnkReturnToBookings" CssClass="returnText" NavigateUrl="~/ViewBooking_1.aspx" runat="server">Return to bookings</asp:HyperLink>
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
        <br />
        <br />
        <div class="pageHeader">Payment success!</div>
        <br />
        <br />
        <asp:Label ID="lblPaymentSuccess" CssClass="lblSuccessInformation" runat="server" Text="Your payment has been successful"></asp:Label>
        <br />
        <br />
        <asp:Button ID="btnReturnToHomePage" CssClass="returnToHomeScreenButton" runat="server" Text="RETURN TO HOMEPAGE" OnClick="btnReturnToHomePage_Click1" />
        <br />
        <br />
        <br />


        <div class="footer">
            © 2020 HOTEL VIRTUE. All rights are reserved. Site NOT for rollout unless for demonstration purposes.
        </div>
    </form>
</body>
</html>
