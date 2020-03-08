<<<%@ Page Language="C#" AutoEventWireup="true" CodeFile="HomePage.aspx.cs" Inherits="HomePage" %>

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
          <a href="#">OTHER OPT
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
            <asp:Label ID="Label2" runat="server" Text="Edit Personal Details"></asp:Label>
             </div>


               <div id="myregistration" class="registration">

             <br />
                   <asp:TextBox ID="TextBox2" runat="server"  required ="required" placeholder="Edit Email Address.."> </asp:TextBox>
             <br />
             <br />
                    <asp:TextBox ID="TextBox3" runat="server"  required ="required" placeholder="Edit Password .."> </asp:TextBox>
                   <br />
                   <br />
                 <asp:TextBox ID="TextBox4" runat="server"  required ="required" placeholder="Edit FirstName.."> </asp:TextBox>
                   <br />
                   <br />
                    <asp:TextBox ID="TextBox5" runat="server"  required ="required" placeholder="Edit LastName.."> </asp:TextBox>
                   <br />
                   <br />
                    <asp:TextBox ID="TextBox6" runat="server"  required ="required" placeholder="Edit PostCode.."> </asp:TextBox>
                   <br />
                    <br />
                    <asp:TextBox ID="TextBox1" runat="server"  required ="required" placeholder="Edit City .."> </asp:TextBox>
                   <br />
                    <br />
                    <asp:TextBox ID="TextBox8" runat="server"  required ="required" placeholder="Edit Street .."> </asp:TextBox>
                   <br />
                   <br />
                    <asp:TextBox ID="TextBox7" runat="server"  required ="required" placeholder="Edit Town.."> </asp:TextBox>
                   <br />
                   <br />
                   <asp:DropDownList ID="DropDownList1" runat="server"></asp:DropDownList>
                   <br />
                   <br />
                   <asp:Button ID="Button1" runat="server" Text="Edit" type="submit" value="Confirm" OnClick="Button1_Click1" />
                   <br />

             </div>

    </form>

    <div class="footer">
            © 2020 HOTEL VIRTUE. All rights are reserved. Site NOT for rollout unless for demonstration purposes.
    poses.
    </div>
</body>
</html>