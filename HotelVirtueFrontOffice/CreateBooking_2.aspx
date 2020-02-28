<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CreateBooking_2.aspx.cs" Inherits="CreateBooking_2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" = href="StyleSheet.css" />

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
        <div class="pageHeader">Review booking</div>
        <br />
        <br />

        <div class="box">
            <asp:Label ID="lblHotelName" runat="server" Text=""></asp:Label>
            <p class="body">
                <br />
                <br />
                <asp:Label ID="lblBookingId" runat="server" Text=""></asp:Label>
                <br />
                <asp:Label ID="lblArrivalDate" runat="server" Text=""></asp:Label>
                <br />
                <asp:Label ID="lblDepartureDate" runat="server" Text=""></asp:Label>
                <br />
                <asp:Label ID="lblUnderFive" runat="server" Text=""></asp:Label>
                <br />
                <asp:Label ID="lblFiveToSixteen" runat="server" Text=""></asp:Label>
                <br />
                <asp:Label ID="lblSixteenUpwards" runat="server" Text=""></asp:Label>
                <br />
                <br />
                <asp:Label ID="lblExtras" runat="server" Text="Extras:"></asp:Label>
                <br />
                <br />
                <asp:Label ID="lblGymAccess" runat="server" Text=""></asp:Label>
                <br />
                <asp:Label ID="lblLateCheckout" runat="server" Text=""></asp:Label>
                <br />
                <br />
                <asp:Label ID="lblCost" CssClass="body leftAlignCost" runat="server" Text=""></asp:Label>
                <br />
            </p>

            <asp:Button ID="btnPayNow" CssClass="payNowButton" runat="server" Text="PAY NOW" />
            <asp:Button ID="btnPayLater" CssClass="payLaterButton" runat="server" Text="PAY LATER" />
            <br />
            <br />
            <br />
        </div>







    <div class="footer">
            © 2020 HOTEL VIRTUE. All rights are reserved. Site NOT for rollout unless for demonstration purposes.
    </div>
    </form>
</body>
</html>
