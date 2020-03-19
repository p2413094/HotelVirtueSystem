<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CreateBooking_2.aspx.cs" Inherits="CreateBooking_2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Create booking</title>
    <link rel="stylesheet" = href="StyleSheet.css" />

</head>
<body class="body">
    <form id="form1" runat="server">
        <div class="logo">
            Hotel Virtue           
        </div>

        <div>
            <ul class="ul" >
                <li><span style="font-size:30px;cursor:pointer" onclick="openNav()">&#9776; MENU</span></li>
                <li class="signInRight"><a href="Login.aspx">SIGN IN/ REGISTER</a></li>
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
              document.getElementById("mySidenav").style.width = "25%";
            }

            function closeNav() {
              document.getElementById("mySidenav").style.width = "0";
            }
        </script>

        <br />
        <br />
        <br />
        <div class="pageHeader">Review booking</div>
        <br />
        <br />


        <asp:Panel ID="pnlError" CssClass="box" runat="server"></asp:Panel>
        <br />    
        <asp:Panel ID="pnlBookingInformation" CssClass="box" runat="server"></asp:Panel>
        


    <div class="footer">
            © 2020 HOTEL VIRTUE. All rights are reserved. Site NOT for rollout unless for demonstration purposes.
    </div>
    </form>
</body>
</html>
