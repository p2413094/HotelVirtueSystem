<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Delete_Booking.aspx.cs" Inherits="Delete_Booking" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
                        <asp:Label ID="lblAddressNo" runat="server" style="z-index: 1; width: 323px;" Text="Are you sure you want to delete this booking?"></asp:Label>
            <br />
            <asp:Button ID="btnYes" runat="server" style="z-index: 1; width: 59px" Text="Yes" OnClick="btnYes_Click"  />
            <asp:Button ID="btnNo" runat="server" height="26px" style="z-index: 1;" Text="No" width="59px" OnClick="btnNo_Click"  />
        </div>
    </form>
</body>
</html>
