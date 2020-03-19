<%@ Page Language="C#" AutoEventWireup="true" CodeFile="DeleteRoom.aspx.cs" Inherits="DeleteRoom" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblDelete" runat="server" style="z-index: 1; left: 126px; top: 134px; position: absolute" Text="Are you sure you want to delete this room?"></asp:Label>
        <asp:Button ID="btnYes" runat="server" OnClick="btnYes_Click" style="z-index: 1; left: 113px; top: 170px; position: absolute" Text="Yes" />
        <asp:Button ID="btnNo" runat="server" style="z-index: 1; left: 174px; top: 171px; position: absolute" Text="No" />
    </form>
</body>
</html>
