<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Index.aspx.cs" Inherits="Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Hotel Virtue</title>
    <link rel="stylesheet" = href="StyleSheet.css" />
</head>

<body>

    <%--<form runat="server">--%>

    <form>
        
    <div id="Logo">
           <img src="Images/HotelVirtueLogo.png" alt="HotelVirtueLogo" height="200" width="300"/>       
        </div>

        <div>
           <ul class="ul" >
                <li><span style="font-size:30px;cursor:pointer" onclick="openNav()">&#9776; MENU</span></li>
                <li class="right"><a href="#">SIGN IN/ REGISTER</a></li>
            </ul>
        </div>

       <div id="mySidenav" class="sidenav">
          <a href="javascript:void(0)" class="closebtn" onclick="closeNav()">&times;</a>
          <a href="Index.aspx">SEARCH FOR HOTEL</a>
          <a href="Offers.aspx">OFFERS</a>
          <a href="ContactDetails.aspx">CONTACT DETAILS</a>
          
     </div>
           
    <asp:Panel ID="Panel1" runat="server"></asp:Panel>
        </form>
        <script>
            function openNav() {
              document.getElementById("mySidenav").style.width = "30%";
            }

            function closeNav() {
              document.getElementById("mySidenav").style.width = "0";
            }
        </script>

    <div id="skylinepicture">
        <img src="Images/skyline.jpg" height="500" width="1900" />
    </div>
    
    <div id="picturetitle">
        <p>Enjoy a Luxury Experience</p>
    </div>

    <form runat="server">
        <div class="form-box">
            <input type="text" class="search-field" placeholder="Destination, City, Postcode..." />
        </div>
            <button class ="search-btn" type="button">Search</button>
            <div id="Labels">
            <label> Date: <asp:TextBox ID="Date" runat="server"></asp:TextBox></label>
            <label> Date of Stay: <asp:TextBox ID="DateofStay" runat="server"></asp:TextBox></label>
            <label> Number of Guests: <asp:TextBox ID="NoOfGuests" runat="server"></asp:TextBox></label>
            <label> Number of Rooms: <asp:TextBox ID="NoOfRooms" runat="server"></asp:TextBox></label>
            </div>
            
            <br />
            &nbsp;
    </form>

     <!-- footer -->
        <div id="footer">
            <!--Text within footer -->
            <p>© 2020 HOTEL VIRTUE. All rights are reserved. Site NOT for rollout unless for demonstration purposes.</p>
        </div>
</body>
</html>
