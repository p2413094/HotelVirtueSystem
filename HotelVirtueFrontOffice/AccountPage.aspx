﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AccountPage.aspx.cs" Inherits="AccountPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Hotel Virtue</title>
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

        <asp:Panel ID="Panel1" runat="server"></asp:Panel>


        <script>
            function openNav() {
              document.getElementById("mySidenav").style.width = "30%";
            }

            function closeNav() {
              document.getElementById("mySidenav").style.width = "0";
            }
        </script>

         <div id="mylogin" class="login" >

         

             <br />
             <asp:Button ID="Button1" runat="server" Text="Edit Details" type="submit" OnClick="Button1_Click"  />
             <br />
             <br />
             <asp:Button ID="Button4" runat="server" Text="Logout" type="submit" OnClick="Button4_Click" />
             <br />
             <br />
             <asp:Button ID="Button3" runat="server" Text="Create Booking" type="submit" OnClick="Button3_Click" />
             <br />
             <br />
             <asp:Button ID="Button2" runat="server" Text="View bookings" OnClick="Button2_Click" />
        
           </div>

        <div id="mysignup" class="signup">
            <asp:Label ID="Label2" runat="server" Text="Account Page"></asp:Label>
             </div>
    </form>
    

    
     

    

    <div class="footer">
            © 2020 HOTEL VIRTUE. All rights are reserved. Site NOT for rollout unless for demonstration purposes.
    </div>
</body>
</html>

