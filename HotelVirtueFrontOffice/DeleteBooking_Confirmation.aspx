<%@ Page Language="C#" AutoEventWireup="true" CodeFile="DeleteBooking_Confirmation.aspx.cs" Inherits="DeleteBooking_Confirmation" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Confirmation</title>
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
                <li class="signInRight"><a href="Login.aspx">SIGN IN/ REGISTER</a></li>
            </ul>
        </div>

        <br />
        <div>
            <asp:HyperLink ID="hyplnkHomePage" CssClass="returnText" NavigateUrl="~/Index.aspx" runat="server">Return to homepage</asp:HyperLink>
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
        <div class="pageHeader">Delete booking success!</div>
        <br />
        <br />
        <asp:Label ID="lblBookingSuccessInformation" CssClass="lblSuccessInformation" runat="server" Text="The booking has been deleted."></asp:Label>
        <br />
        <br />
        <asp:Button ID="btnReturnToHomePage" CssClass="returnToHomeScreenButton" runat="server" Text="RETURN TO HOMEPAGE" OnClick="btnReturnToHomePage_Click" />
        <br />
        <br />
        <br />

    </form>
</body>
</html>
