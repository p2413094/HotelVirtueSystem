<%@ Page Language="C#" AutoEventWireup="true" CodeFile="PayForBooking_1.aspx.cs" Inherits="PayForBooking_1" %>

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
                <li class="right"><a href="#">SIGN IN/ REGISTER</a></li>
            </ul>
        </div>

        <div>
            <p class="returnText">
                <a href="HomePage">Return to home page</a>  
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
              document.getElementById("mySidenav").style.width = "30%";
            }

            function closeNav() {
              document.getElementById("mySidenav").style.width = "0";
            }
        </script>

        <p class="pageHeader">Pay for booking</p>

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
            </p>
        </div>

        <br />
        <br />

        <div class="box">
            <p class="payForBookingHeader">Please enter your card details below</p>
            <p class="body">
                16-digit card number: 
                <asp:TextBox ID="txtCardNumber" runat="server"></asp:TextBox>
                <br />
                <br />
                Name on card: 
                <asp:TextBox ID="txtNameOnCard" runat="server"></asp:TextBox>
                <br />
                <br />
                Expiry date:
                <asp:TextBox ID="txtExpiryDate" runat="server"></asp:TextBox>
                <br />
                <br />
                3-digit security code:
                <asp:TextBox ID="txtSecurityCode" runat="server"></asp:TextBox>
                <br />
                <br />
                <br />
                <asp:Button CssClass="continueButton" ID="btnSubmit" Text="Submit" runat="server" OnClick="btnSubmit_Click" />
                <br />
                <br />
            </p>
        </div>
    </form>
</body>
</html>
