<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" %>

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

         <div id="mylogin" class="login">

         
             <br />
             <asp:Label ID="Label1" runat="server" Text="UserName"></asp:Label>
            <asp:TextBox ID="txtUserName" runat="server"></asp:TextBox>
             <br />
             <br />
             <asp:Label ID="Label3" runat="server" Text="Password"></asp:Label>
            <asp:TextBox ID="txtPassword" runat="server" type="password"></asp:TextBox>
             <br />
             <br />
             <asp:Button ID="Button1" runat="server" Text="Login" type="submit" OnClick="Button1_Click"  />
             <br />
             <br />
             <asp:Button ID="Button2" runat="server" Text="Register" type="submit" OnClick="Button2_Click" />
             <br />
             <br />
             <asp:Button ID="Button3" runat="server" Text="Sign up as Guest" type="submit" OnClick="Button3_Click" />
           </div>

        <div id="mysignup" class="signup">
            <asp:Label ID="Label2" runat="server" Text="Sign up"></asp:Label>
             </div>
    </form>
    

    
     

    

    <div class="footer">
            © 2020 HOTEL VIRTUE. All rights are reserved. Site NOT for rollout unless for demonstration purposes.
    </div>
</body>
</html>

