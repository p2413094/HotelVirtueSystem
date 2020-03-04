<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CreateBooking_Confirmation.aspx.cs" Inherits="CreateBooking_Confirmation" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="StyleSheet.css" />
</head>
<body class="body">
    <form id="form1" runat="server">
        <div class="logo">
            Hotel Virtue
        </div>

        <div>
            <ul class="ul" >
                <li><span style="font-size:30px;cursor:pointer" onclick="openNav()">&#9776; MENU</span></li>
                <li class="signInRight"><a href="#">SIGN IN/ REGISTER</a></li>
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
              document.getElementById("mySidenav").style.width = "25%";
            }

            function closeNav() {
              document.getElementById("mySidenav").style.width = "0";
            }
        </script>

        <br />
        <br />
        <br />
        <div class="pageHeader">Booking success!</div>
        <br />
        <br />
        <asp:Label ID="lblBookingSuccessInformation" CssClass="lblBookingSuccessInformation" runat="server" Text="Your booking has been created and your chosen hotel has been sent the booking"></asp:Label>
        <br />
        <br />
        <asp:Button ID="btnReturnToHomePage" CssClass="returnToHomeScreenButton" runat="server" Text="RETURN TO HOMEPAGE" />
        <br />
        <br />


        <div class="footer">
            © 2020 HOTEL VIRTUE. All rights are reserved. Site NOT for rollout unless for demonstration purposes.
        </div>
    </form>
</body>
</html>
