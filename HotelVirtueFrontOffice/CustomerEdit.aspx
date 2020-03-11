<<<%@ Page Language="C#" AutoEventWireup="true" CodeFile="HomePage.aspx.cs" Inherits="HomePage" %>

<!DOCTYPE html>

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
          <a href="#">CONTACT DETAILS</a>
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
                   <asp:ListBox ID="ListBox1" runat="server" Height="319px" Width="511px" OnSelectedIndexChanged="ListBox1_SelectedIndexChanged"></asp:ListBox>
                   <br />
                   <br />
                   <asp:Label ID="Label1" runat="server" Text="Enter AccountId "></asp:Label>
                   <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                   <br />
                   <br />
                    <asp:Button ID="Button1" runat="server" Text="Add" type="submit" value="Confirm" OnClick="Button1_Click1" />
                    <asp:Button ID="Button2" runat="server" Text="Edit" type="submit" value="Confirm" OnClick="Button1_Click1" />
                    <asp:Button ID="Button3" runat="server" Text="Delete" type="submit" value="Confirm" OnClick="Button1_Click1" />
                   <br />
             </div>

    </form>

    <div class="footer">
            © 2020 HOTEL VIRTUE. All rights are reserved. Site NOT for rollout unless for demonstration purposes.
    poses.
     purposes.
    poses.
    s.
    </div>
</body>
</html>
