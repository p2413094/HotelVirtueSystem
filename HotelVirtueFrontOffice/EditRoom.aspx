﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="EditRoom.aspx.cs" Inherits="EditRoom" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:ListBox ID="lstRooms" runat="server" style="z-index: 1; left: 418px; top: 166px; position: absolute; height: 256px; width: 467px"></asp:ListBox>
        <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" style="z-index: 1; left: 445px; top: 457px; position: absolute" Text="Edit" />
        <p>
            <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 412px; top: 426px; position: absolute; height: 28px"></asp:Label>
        </p>
        <asp:Button ID="btnDisplayAll" runat="server" OnClick="btnDisplayAll_Click" style="z-index: 1; left: 493px; top: 457px; position: absolute" Text="Display All" />
        <asp:Button ID="btnApply" runat="server" OnClick="btnApply_Click" style="z-index: 1; left: 634px; top: 458px; position: absolute" Text="Apply" />
        <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" style="z-index: 1; left: 373px; top: 456px; position: absolute" Text="Delete" />
    </form>
</body>
</html>
