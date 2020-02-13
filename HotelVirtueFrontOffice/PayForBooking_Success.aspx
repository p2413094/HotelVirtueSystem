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
                <a href="ViewBooking_1.aspx">Return to view booking page</a>  
            </p>   
        </div>

        <p class="pageHeader">Payment success!</p>
        <br />
        <p class="pageInformation">
            Your payment was successfully processed.
            <br />
            <br />
        </p>
        <asp:Button CssClass="returnToHomeScreenButton" ID="btnReturnToHomePage" runat="server" Text="RETURN TO HOME PAGE" OnClick="btnReturnToHomePage_Click" />       
    </form>
</body>
</html>
