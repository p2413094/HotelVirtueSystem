<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ViewBooking_2.aspx.cs" Inherits="ViewBooking_2" %>

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
                <li class="signInRight"><a href="ViewBooking_1.aspx">SIGN IN/ REGISTER</a></li>
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
                <a href="ViewBooking_1.aspx">Return to bookings</a>  
            </p>   
        </div>

        <asp:Label ID="lblBookingReference" CssClass="pageHeader" runat="server" Text=""></asp:Label>

        <br />
        <br />
        <div class="box">
            <asp:Label ID="lblHotelName" runat="server" Text="Hotel name: "></asp:Label>
            <p class="body">
                <asp:Label ID="lblCheckIn" runat="server" Text="Arrival date: "></asp:Label>
                <br />
                <asp:Label ID="lblCheckout" runat="server" Text="Departure date: "></asp:Label>
                <br />
                <asp:Label ID="lblRoomType" runat="server" Text="Room type: "></asp:Label>
                <br />
                <asp:Label ID="lblUnderFive" runat="server" Text="Under five: "></asp:Label>
                <br />
                <asp:Label ID="lblFiveToSixteen" runat="server" Text="Five to sixteen: "></asp:Label>
                <br />
                <asp:Label ID="lblSixteenUpwards" runat="server" Text="Sixteen upwards: "></asp:Label>
                <br />
                <asp:Label ID="lblOther" runat="server" Text="Other: "></asp:Label>
                <br />
                <br />
                Extras
                <br />
                <asp:Label ID="lblGymAccess" runat="server" Text="Gym access: "></asp:Label>
                <br />
                <asp:Label ID="lblLateCheckout" runat="server" Text="Late checkout: "></asp:Label>
                <br />
                <br />
            </p>

            <p class="body leftAlignCost">
                <asp:Label ID="lblStatus" runat="server" Text="Status: "></asp:Label>
                <br />
                <asp:Label ID="lblTotal" runat="server" Text="Total: £"></asp:Label>                
            </p>
            <br />
            <br />
        </div>
     </form>
</body>
</html>
