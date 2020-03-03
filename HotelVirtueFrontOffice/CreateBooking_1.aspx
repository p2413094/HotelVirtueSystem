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




        <div class="box">
            <asp:Panel ID="pnlExtras" runat="server">Extras</asp:Panel>
            <p class="body">
                <asp:Label ID="lblGymAccess" runat="server" Text="Gym access"></asp:Label>
                <br />
                <br />
                <asp:Image ID="imgGym" CssClass="clearfix image" ImageUrl="~/Images/Gym.png" runat="server" />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />

            </p>
            <p class="body">
                <asp:Label ID="lblLateCheckout" runat="server" Text="Late check-out"></asp:Label>
                <br />
                <br />
                <asp:Image ID="imgLateCheckout" CssClass="clearfix image" ImageUrl="~/Images/Late-Check-Out.jpg" runat="server" />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />

            </p>
        </div>
        
                    
    <div class="footer" id="footer">
            © 2020 HOTEL VIRTUE. All rights are reserved. Site NOT for rollout unless for demonstration purposes.
    </div>
</form>
</body>
</html>
