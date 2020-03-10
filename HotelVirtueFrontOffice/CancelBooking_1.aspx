<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CancelBooking_1.aspx.cs" Inherits="CancelBooking_1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Cancel booking</title>
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


        <p class="pageHeader">Cancel booking</p>

        <br />
        <asp:Panel ID="errorPanel" CssClass="box" runat="server"></asp:Panel>
        <br />

        <asp:Panel ID="pnlBooking" CssClass="box" runat="server">
            <asp:Label ID="lblHotelName" runat="server" Text=""></asp:Label>
            <p class="body">
                <asp:Label ID="lblBookingLineId" runat="server" Text=""></asp:Label>
                <br />
                <br />
                <asp:Label ID="lblCheckIn" runat="server" Text=""></asp:Label>
                <br />
                <asp:Label ID="lblCheckOut" runat="server" Text=""></asp:Label> 
                <br />
                <asp:Label ID="lblRoomType" runat="server" Text=""></asp:Label>
                <br />
                <asp:Label ID="lblUnderFive" runat="server" Text=""></asp:Label>
                <br />
                <asp:Label ID="lblFiveToSixteen" runat="server" Text=""></asp:Label>
                <br />
                <asp:Label ID="lblSixteenUpwards" runat="server" Text=""></asp:Label>
                <br />
                <br />
                Extras
                <br />
                <br />
                <asp:Label ID="lblGymAccess" runat="server" Text=""></asp:Label>
                <br />
                <asp:Label ID="lblLateCheckout" runat="server" Text=""></asp:Label>
                <br />
                <asp:Label ID="lblCost" CssClass="leftAlignCost" runat="server" Text=""></asp:Label>
                <br />
                <br />       
            </p>
            <p> Please enter a booking reason or choose from one of the pre-selected options:</p>
            <asp:DropDownList ID="ddlCancellationReason" AutoPostBack="true" runat="server" OnSelectedIndexChanged="ddlCancellationReason_SelectedIndexChanged">
                <asp:listitem text="Room cheaper elsewhere" value="0"></asp:listitem>
                <asp:listitem text="Booked accidentally" value="1"></asp:listitem>
                <asp:listitem text="Chose wrong hotel" value="2"></asp:listitem>
                <asp:listitem text="Chose wrong room" value="3"></asp:listitem>
                <asp:listitem text="Wrong payment method" value="4"></asp:listitem>
                <asp:listitem text="Other" value="5"></asp:listitem>
            </asp:DropDownList>
            <br />
            <br />
            <asp:Label ID="lblEnterReason" CssClass="body" runat="server" Text="Please enter reason in box below"></asp:Label>
            <br />
            <asp:TextBox ID="txtReason" CssClass="multiLineTextField" TextMode="MultiLine" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button CssClass="continueButton" ID="btnCancelBooking" runat="server" Text="CANCEL BOOKING" OnClick="btnCancelBooking_Click" />
            <br />
            <br />
            <br />
        </asp:Panel>
        
    </form>


</body>
</html>
