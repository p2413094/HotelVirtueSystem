<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CancelBooking_1.aspx.cs" Inherits="CancelBooking_1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Cancel booking</title>
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

        <div>
            <p class="returnText">
                <a href="HomePage">Return to home page</a>  
            </p>   
        </div>

        <div id="mySidenav" class="sidenav">
          <a href="javascript:void(0)" class="closebtn" onclick="closeNav()">&times;</a>
          <a href="#">SEARCH FOR HOTEL</a>
          <a href="#">OFFERS</a>
          <a href="#">CONTACT DETAILS</a>
          <a href="#">OTHER OPTION HERE</a>
        </div>

        <script>
            function openNav() {
              document.getElementById("mySidenav").style.width = "30%";
            }

            function closeNav() {
              document.getElementById("mySidenav").style.width = "0";
            }
        </script>

        <p class="pageHeader">Cancel booking</p>

        <br />
        <br />
        <div class="box">
            Hotel number 1
            <p class="body">
                Booking reference: #001
                <br />
                <br />
                Check-in: 26/01/2020
                <br />
                Check-out: 27/01/2020 
                <br />
                Room type: single bed 
                <br />
                <br />
                Extras
                <br />
                Gym access
                <br />
                Breakfast
                <p class="body" style="float: right;">Total: £x</p>
                <br />
                <br />       
            </p>
            <p> Please enter a booking reason or choose from one of the pre-selected options:</p>
            <asp:DropDownList ID="ddlCancellationReason" name="ddl1" runat="server" AutoPostBack="True">
                <asp:listitem text="Room cheaper elsewhere" value="0"></asp:listitem>
                <asp:listitem text="Booked accidentally" value="1"></asp:listitem>
                <asp:listitem text="Chose wrong hotel" value="2"></asp:listitem>
                <asp:listitem text="Chose wrong room" value="3"></asp:listitem>
                <asp:listitem text="Wrong payment method" value="4"></asp:listitem>
                <asp:listitem text="Other" value="5"></asp:listitem>
            </asp:DropDownList>
            <asp:Button CssClass="continueButton" ID="btnCancelBooking" runat="server" Text="CANCEL BOOKING" OnClick="btnCancelBooking_Click" />

            <%
                if(ddlCancellationReason.SelectedIndex == 5)
                {
                    Response.Write("<p class='body'>");
                    Response.Write("Please enter reason in box below:");
                    Response.Write("</p>");
                    Response.Write("<textarea rows = '4' cols='50'></textarea>");
                }
            %>
            <br />
            <br />

        </div>
    </form>

    <script>
        function ConfirmCancellation() {
            var answer = confirm("Confirm cancellation?");
            if (answer == true) {
                Response.redirect("CancelBooking_2.aspx");
            }
            else {

            }
       }
    </script>

</body>
</html>
