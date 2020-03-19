<<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Registration.aspx.cs" Inherits="Registration" %>

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
          <a href="#">CONTACT
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
    
          <div id="myregistrationlabel" class="registrationlabel">
            <asp:Label ID="Label2" runat="server" Text="Registration"></asp:Label>
             </div>


               <div id="myregistration" class="registration">
               <br />
                   <asp:Label ID="Label1" runat="server" Text="CustomerId"></asp:Label>
                   <asp:TextBox ID="txtCustomerId" runat="server"></asp:TextBox>
                   <br />
                   <br />
                   <asp:Label ID="Label3" runat="server" Text="City"></asp:Label>
                   <asp:TextBox ID="txtCity" runat="server"></asp:TextBox>
                   <br />
                   <br />
                   <asp:Label ID="Label4" runat="server" Text="HouseNo"></asp:Label>
                   <asp:TextBox ID="txtHouseNo" runat="server"></asp:TextBox>
                   <br />
                   <br />
                   <asp:Label ID="Label5" runat="server" Text="Password"></asp:Label>
                   <asp:TextBox ID="txtPassword" runat="server"></asp:TextBox>
                   <br />
                   <br />
                   <asp:Label ID="Label6" runat="server" Text="PostCode"></asp:Label>
                   <asp:TextBox ID="txtPostCode" runat="server"></asp:TextBox>
                   <br />
                   <br />
                   <asp:Label ID="Label7" runat="server" Text="Street"></asp:Label>
                   <asp:TextBox ID="txtStreet" runat="server"></asp:TextBox>
                   <br />
                   <br />
                   <asp:Label ID="Label8" runat="server" Text="Town"></asp:Label>
                   <asp:TextBox ID="txtTown" runat="server"></asp:TextBox>
                   <br />
                   <br />
                   <asp:Label ID="Label10" runat="server" Text="UserName"></asp:Label>
                   <asp:TextBox ID="txtUserName" runat="server"></asp:TextBox>
                   <br />
                   <br />
                     <asp:Label ID="lblErrorText" runat="server" Text="[lblError]"></asp:Label>
                   <br />
                   <br />
                   <asp:Button ID="Button1" runat="server" Text="Register" OnClick="Button1_Click" />
                   <br />
             </div>

    </form>

    <div class="footer">
            © 2020 HOTEL VIRTUE. All rights are reserved. Site NOT for rollout unless for demonstration purposes.
    poses.
    poses.
    poses.
    </div>
</body>
</html>
