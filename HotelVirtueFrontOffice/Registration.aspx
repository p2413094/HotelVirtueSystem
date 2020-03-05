<<%@ Page Language="C#" AutoEventWireup="true" CodeFile="HomePage.aspx.cs" Inherits="HomePage" %>

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
    </form>

    <form>
          

               

                <label for="eddress"></label>
                <input type="text" id="eddress" name="email address" required placeholder="Your Email Address..">

                <label for="pword">Password</label>
                <input type="password" id="pword" name="password" required placeholder="Your password..">

        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>

                <label for="lname">Last Name</label>
                <input type="text" id="lname" name="last Name" required placeholder="Your Last Name..">

                <label for="eddress">Email Address</label>
                <input type="text" id="eddress" name="email address"required  placeholder="Your Email Address..">

                <label for="pword">Password</label>
                <input type="password" id="pword" name="password" required placeholder="Your password..">

                <label for="town">Town</label>
                <input type="text" id="town" name="town" required placeholder="Your Town..">

                <label for="pstcode">PostCode</label>
                <input type="text" id="pstcode" name="postcode" required placeholder="Your PostCode..">

                <label for="city">City</label>
                <select id="city" name="city">
                    <option value="London">London</option>
                    <option value="Birmingham">Birmingham</option>
                    <option value="Leicester">Leicester</option>
                </select>


                <input type="submit" value="Register">



    </form>

    <div class="footer">
            © 2020 HOTEL VIRTUE. All rights are reserved. Site NOT for rollout unless for demonstration purposes.
    </div>
</body>
</html>
