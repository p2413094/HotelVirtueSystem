<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CreateBooking_1.aspx.cs" Inherits="CreateBooking_1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
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

        <p>
            <asp:Table CssClass="bookingTable" runat="server">
                <asp:TableRow CssClass="stayHeaders">
                    <asp:TableCell CssClass="stayHeaders">
                        Chosen hotel
                    </asp:TableCell>
                    <asp:TableCell CssClass="stayHeaders">
                        Dates of stay
                    </asp:TableCell>
                    <asp:TableCell CssClass="stayHeaders">
                        Guests
                    </asp:TableCell>
                    <asp:TableCell CssClass="stayHeaders">
                        Sub-total
                    </asp:TableCell>
                </asp:TableRow>
                
                <asp:TableRow>
                    <asp:TableCell CssClass="stayGeneralText">
                        <asp:Label ID="lblHotelName" runat="server" Text=""></asp:Label>
                    </asp:TableCell>
                    <asp:TableCell CssClass="stayGeneralText">
                        <asp:Label ID="lblArrivalDepartureDate" runat="server" Text=""></asp:Label>
                    </asp:TableCell>
                    <asp:TableCell CssClass="stayGeneralText">
                        <asp:Label ID="lblbreakdownOfGuests" runat="server" Text=""></asp:Label>
                    </asp:TableCell>
                    <asp:TableCell CssClass="stayGeneralText">
                        <asp:Label ID="lblCost" runat="server" Text=""></asp:Label>
                    </asp:TableCell>
                </asp:TableRow>
            </asp:Table>
        </p>
   
        <p class="pageHeader">Room selection</p>

        <br />

        <asp:Panel ID="pnlBooking" CssClass="box clearfix" runat="server"></asp:Panel>

        <br />
        
        <div class="box">
            Optional extras    
            <div class="clearfix">
                <br />
                <div class="body">Gym access</div>
                <img src="Images/Gym.png" class="image"/>
                <p class="subHeader">Add to booking?</p>
                    <asp:RadioButtonList ID="RadioButtonList1" runat="server" CssClass="rateOptions">
                        <asp:ListItem>Yes - +£10.00</asp:ListItem>
                        <asp:ListItem>No - +£0.00</asp:ListItem>
                    </asp:RadioButtonList>  
                    <br />
            </div>
            <br />

            <div class="clearfix">
                <div class="body">Breakfast</div>
                <img src="Images/Breakfast.jpg" class="image"/>
                    <asp:RadioButtonList ID="RadioButtonList2" runat="server" CssClass="rateOptions">
                        <asp:ListItem>Yes - +£10.00</asp:ListItem>
                        <asp:ListItem>No - +£0.00</asp:ListItem>
                    </asp:RadioButtonList>  
                    <br />
            </div>
            
        </div>
        <br />
        <br />

        <div class="box">
            Your booking
            <p class="body">
                Your option
                <br />
                Your option 
                <br />
                Your option
                <p class="body" style="float: right;">Total: £x</p>
                <br />
                <br />
                <asp:Button CssClass="continueButton" ID="btnContinueToPayment" Text="PROCEED TO PAYMENT" runat="server" OnClick="btnContinueToPayment_Click" />
                <br />

            </p>
        </div>
        <br />
        <br />

    <div class="footer">
            © 2020 HOTEL VIRTUE. All rights are reserved. Site NOT for rollout unless for demonstration purposes.
    </div>
</form>
</body>
</html>
