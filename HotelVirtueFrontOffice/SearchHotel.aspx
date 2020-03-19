<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SearchHotel.aspx.cs" Inherits="SearchHotel" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="StyleSheet.css" />
</head>
<body class="body">
    <form id="form1" runat="server">
        <div>
        </div>


        <asp:Panel ID="pnlchoosebooking" CssClass="box" runat="server">
            <asp:Label ID="lblchoosehotel" runat="server" Text="Choose the hotel"></asp:Label>
            <br />
            <asp:DropDownList ID="ddlHotelId" runat="server"></asp:DropDownList>
            <br />
            <asp:Button ID="Buttonchoosebooking" CssClass="continueButton" runat="server" Text="choose this hotel" OnClick="Buttonchoosebooking_Click" />

        </asp:Panel>
    </form>
</body>
</html>
