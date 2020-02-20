<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Booking_Confirmation.aspx.cs" Inherits="Booking_Confirmation" %>

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
                <li><span class="menuButton" onclick="openNav()">&#9776; MENU</span></li>
                <li class="right"><a href="#">SIGN IN/ REGISTER</a></li>
            </ul>
        </div>

        <div>
            <p class="returnText">
                <a href="CreateBooking_1.aspx">Return to room information</a>  
            </p>   
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

        <p class="pageHeader">Booking confirmation</p>

        <div class="box">
            Hotel name/ location
            <p class="body">
                Booking reference: #001
                <br />
                <br />
                Check-in: 26/01/2020
                <br />
                Check-out: 27/01/2020 
                <br />
                Room type: single bed 

                <p class="body" style="float: right;">Total: £x</p>
                <br />
                <br />
                <asp:Button CssClass="payNowButton" ID="btnPayNow" Text="PAY NOW" runat="server" />
                <asp:Button CssClass="payLaterButton" ID="btnPayLater" Text="PAY LATER" runat="server" />
                <br />
                <br />
            </p>
        </div>
    </form>
</body>
</html>
