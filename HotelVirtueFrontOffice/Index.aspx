﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Index.aspx.cs" Inherits="Index" %>

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
           &nbsp;</div>

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

    <form runat="server">

    <div id="skylinepicture">
        <asp:Button ID="btnSearch" runat="server" OnClick="btnSearch_Click" style="z-index: 1; left: 1336px; top: 144px; position: absolute" Text="Search" />
        &nbsp;</div>
    
    <div id="picturetitle">
        <p>Enjoy a Luxury Experience</p>
    </div>

       
                   
            <div id="Labels" class="hotel">
            <label> Location:<asp:TextBox ID="txtLocation" runat="server" placeholder="Leicester" ></asp:TextBox> Arrival Date: <asp:TextBox ID="txtArrivalDate" runat="server" placeholder="DD/MM/YYYY"></asp:TextBox>Departure Date:<asp:TextBox ID="txtDepartureDate" runat="server" placeholder="DD/MM/YYYY"></asp:TextBox>Number of Guests: <asp:TextBox ID="txtNumberOfGuests" runat="server"></asp:TextBox></label>
                <br />
                <label> &nbsp;</label>Under Five:<asp:TextBox ID="txtUnderFive" runat="server" style="z-index: 1; left: 149px; top: 176px; position: absolute"></asp:TextBox>
                <br />
            <br />
                <label> &nbsp;Five to Sixteen:<br />
                <asp:TextBox ID="txtFivetoSixteen" runat="server" style="z-index: 1; left: 176px; top: 230px; position: absolute"></asp:TextBox>
                Sixteen Upwards:<asp:TextBox ID="txtSixteenUpwards" runat="server" style="z-index: 1; left: 189px; top: 262px; position: absolute"></asp:TextBox>
                </label></div>
            
    </form>

        <p>
        <img src="Images/skyline.jpg" height="500" width="1900" /></p>
        

    
            
    <div id="footer">
            <!--Text within footer -->
            <p>© 2020 HOTEL VIRTUE. All rights are reserved. Site NOT for rollout unless for demonstration purposes.</p>
                </div>
    </body>
</html>
