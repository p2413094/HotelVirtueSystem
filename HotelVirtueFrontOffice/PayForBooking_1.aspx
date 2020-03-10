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
                <li class="signInRight"><a href="#">SIGN IN/ REGISTER</a></li>
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
              document.getElementById("mySidenav").style.width = "30%";
            }

            function closeNav() {
              document.getElementById("mySidenav").style.width = "0";
            }
        </script>

        <asp:Panel ID="errorPanel" CssClass="box" runat="server"></asp:Panel>

        <br />
        <br />
        <br />
        <div class="payForBookingHeader">Pay for booking</div>
        <div class="welcomeName">
            <asp:Label ID="lblFullName" runat="server" Text=""></asp:Label>
        </div>
        <br />
        <br />
        <br />
        <br />
 
        <div class="box">
            <asp:Label ID="lblHotelName" runat="server" Text=""></asp:Label>
            <p class="body">
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
                <asp:Label ID="lblTotal" CssClass="body leftAlignCost" runat="server" Text=""></asp:Label>
                <br />
            </p>
        </div>

        <br />
        <br />

        <div class="box">
            <p class="centreSlantedHeader">Please enter your details below</p>
            <div class="body">
                <div>
                    <div class="left">
                        16-digit card number: 
                    </div>
                    <div class="right">
                        <asp:TextBox ID="txtCardNumber" CssClass="fieldBoxSize" runat="server"></asp:TextBox>
                    </div>
                    <br />
                    <br />
                    <div class="left">
                        Name on card: 
                    </div>
                    <div class="right">
                        <asp:TextBox ID="txtNameOnCard" CssClass="fieldBoxSize" runat="server"></asp:TextBox>
                    </div>
                    <br />
                    <br />
                    <div class="left">
                        Expiry date:
                    </div>
                    <div class="right">
                        <asp:TextBox ID="txtExpiryDate" CssClass="fieldBoxSize" runat="server"></asp:TextBox>
                    </div>
                    <br />
                    <br />
                    <div class="left">
                        3-digit security code:
                    </div>
                    <div class="right">
                        <asp:TextBox ID="txtSecurityCode" CssClass="fieldBoxSize" TextMode="Password" runat="server" />
                    </div>
                    <br />
                    <br />
                    <div class="left">
                        Card type
                    </div>
                    <div class="right">
                        <asp:DropDownList ID="ddlCardType" CssClass="fieldBoxSize" runat="server">
                            <asp:ListItem>VISA</asp:ListItem>
                            <asp:ListItem>MasterCard</asp:ListItem>
                        </asp:DropDownList>
                    </div>
                    <br />
                    <br />
            </div>
         </div>
            <br />
            <br />
            <asp:Button CssClass="continueButton" ID="btnSubmit" Text="Submit" runat="server" OnClick="btnSubmit_Click" />
            <br />
            <br />
        </div>
    </form>
</body>
</html>
