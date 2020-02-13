﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ViewBooking_1.aspx.cs" Inherits="ViewBooking_1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>View bookings</title>
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
                <li class="right"><a href="#">SIGN IN/ REGISTER</a></li>
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

        <div>
            <p class="returnText">
                <a href="HomePage">Return to home page</a>  
            </p>   
        </div>

        <p class="pageHeader">Current bookings</p>

        <br />
        <br />
        <div class="box">
            Hotel number 1
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
                <asp:Button CssClass="continueButton" ID="btnViewBooking" runat="server" Text="VIEW BOOKING" OnClick="btnViewBooking_Click" />
                <br />
                <br />
                <asp:Button ID="btnCancel" CssClass="continueButton" runat="server" Text="CANCEL BOOKING" OnClick="btnCancel_Click" />
                <br />
                <br />
                <asp:Button ID="btnPayForBooking" CssClass="continueButton" runat="server" Text="PAY FOR BOOKING" OnClick="btnPayForBooking_Click" />
                <br />
                <br />
            </p>
        </div>
        <br />
        <br />

    </form>
</body>
</html>
