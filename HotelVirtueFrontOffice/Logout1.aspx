<<<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Logout1.aspx.cs" Inherits="Logout1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Hotel Virtue</title>
    <link rel="stylesheet" = href="StyleSheet2.css" />
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
          OTHER OPT
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
    
          <div id="myregistrationlabel" class="editlabel">
            <asp:Label ID="Label2" runat="server" Text="Are you sure you want to logout"></asp:Label>
               <br />
             <asp:Button ID="Button2" runat="server" Text="Yes" type="submit" value="Submit" OnClick="Button2_Click2" />

             <asp:Button ID="Button1" runat="server" Text="No" type="submit" value="Register" OnClick="Button1_Click2" />
      
      
             <br />
      
             </div>



           

    </form>

    <div class="footer">
            © 2020 HOTEL VIRTUE. All rights are reserved. Site NOT for rollout unless for demonstration purposes.
    poses.
    poses.
    </div>
</body>
</html>
