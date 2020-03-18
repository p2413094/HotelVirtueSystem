<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ARoom.aspx.cs" Inherits="ARoom" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Button ID="lblEdit" runat="server" OnClick="lblEdit_Click" style="z-index: 1; left: 318px; top: 293px; position: absolute" Text="Edit" />
        <asp:ListBox ID="lstRooms" runat="server" style="z-index: 1; left: 516px; top: 165px; position: absolute"></asp:ListBox>
    </form>
</body>
</html>
