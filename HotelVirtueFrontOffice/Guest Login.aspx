<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Guest Login.aspx.cs" Inherits="Guest_Login" %>

<!DOCTYPE html>
<script runat="server">


</script>


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

         <div id="GuestLogin" class="guestlogin">

         
             <br />
             <asp:Label ID="FirstNamelbl" runat="server" Text="FirstName"></asp:Label>
             <asp:TextBox ID="FirstNametxt" runat="server"  required ="required" placeholder="Your Email Address here.."> </asp:TextBox>
             <br />
             <br />
             <asp:Label ID="LastNamelbl" runat="server" Text="LastName"></asp:Label>
             <asp:TextBox ID="LastNametxt" runat="server"  required ="required" placeholder="Your FirstName here.."> </asp:TextBox>
             <br />
             <br />
             <asp:Label ID="EmailAddresslbl" runat="server" Text="EmailAddress"></asp:Label>
              <asp:TextBox ID="EmailAddresstxt" runat="server"  required ="required" placeholder="Your LastName here.."> </asp:TextBox>
             <br />
             <br />
             <asp:Label ID="ContactNumberlbl" runat="server" Text="ContactNumber"></asp:Label>
              <asp:TextBox ID="ContactNumbertxt" runat="server"  required ="required" placeholder=" ContactNumber here.."> </asp:TextBox>
             <br />
             <br />
             <asp:Button ID="Button2" runat="server" Text="Register" type="submit" value="Register" OnClick="Button2_Click1" />
             <br />
      
           </div>

        <div id="mysignup" class="signup">
            <asp:Label ID="Label2" runat="server" Text="Guest SignUp"></asp:Label>
             </div>
    </form>
    

    