<<<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerEdit2.aspx.cs" Inherits="CustomerEdit2" %>

<!DOCTYPE html>
<script runat="server">




</script>


<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">Hotel Virtue</title>
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
          <a hOTHER OPT
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
            <asp:Label ID="Label2" runat="server" Text="Users"></asp:Label>
             </div>


               <div id="myregistration" class="registration">

                   <br />
                   <asp:Label ID="Label1" runat="server" Text="CustomerId"></asp:Label>
                   <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                   <br />
                   <br />
                   <asp:Label ID="Label3" runat="server" Text="City"></asp:Label>
                   <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                   <br />
                   <br />
                   <asp:Label ID="Label4" runat="server" Text="HouseNo"></asp:Label>
                   <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                   <br />
                   <br />
                   <asp:Label ID="Label5" runat="server" Text="Password"></asp:Label>
                   <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
                   <br />
                   <br />
                   <asp:Label ID="Label6" runat="server" Text="PostCode"></asp:Label>
                   <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
                   <br />
                   <br />
                   <asp:Label ID="Label7" runat="server" Text="Street"></asp:Label>
                   <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
                   <br />
                   <br />
                   <asp:Label ID="Label8" runat="server" Text="Town"></asp:Label>
                   <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
                   <br />
                   <br />
                     <asp:Label ID="Label9" runat="server" Text="[lblError]"></asp:Label>
                   <br />
                   <br />
                   <asp:Button ID="Button1" runat="server" Text="OK" OnClick="Button1_Click" />
                   <asp:Button ID="Button2" runat="server" Text="Cancel" OnClick="Button2_Click" />
                   </div>
      

        

    </form>

    <div class="footer">
            © 2020 HOTEL VIRTUE. All rights are reserved. Site NOT for rollout unless for demonstration purposes.
    poses.
     purposes.
    poses.
    s.
        s.
    </div>
</body>
</html>
