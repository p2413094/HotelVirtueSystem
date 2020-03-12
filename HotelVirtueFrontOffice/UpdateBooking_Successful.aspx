<%@ Page Language="C#" AutoEventWireup="true" CodeFile="UpdateBooking_Successful.aspx.cs" Inherits="UpdateBooking_Successful" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Success</title>
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
        <asp:Label ID="lblPageHeader" CssClass="pageHeader" runat="server" Text="Update successful!"></asp:Label>
        <br />
        <br />
        <asp:Panel ID="Panel1" CssClass="box" runat="server">
            <div class="body">
                Your booking has been succesfully updated.
            </div>
            <br />
            <asp:Button ID="btnReturnToHomePage" CssClass="leftButton" runat="server" Text="RETURN TO HOME PAGE" OnClick="btnReturnToHomePage_Click" />
            <br />
            <br />
        </asp:Panel>
        <br />
    </form>
</body>
</html>
