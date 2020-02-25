<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
                        <asp:ListBox ID="lstAddresses" runat="server" style="z-index: 1; height: 197px; width: 327px"></asp:ListBox>
                        <br />
            <asp:Label ID="lblError" runat="server" style="z-index: 1; width: 393px"></asp:Label>

            <br />
            <br />
            <asp:Label ID="lblPostCode" runat="server" style="z-index: 1; width: 317px" Text="Please Enter a Post Code"></asp:Label>
            <br />
            <asp:TextBox ID="txtPostCode" runat="server" style="z-index: 1; width: 169px"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="btnApply" runat="server" style="z-index: 1; width: 119px" Text="Apply"  />
            <asp:Button ID="btnDisplayAll" runat="server" height="26px" style="z-index: 1; width: 119px" Text="Display All" />
            <br />
            <br />
            <asp:Button ID="btnAdd" runat="server" style="z-index: 1; " Text="Add" height="26px" width="55px" OnClick="btnAdd_Click"   />
            <asp:Button ID="btnEdit" runat="server" style="z-index: 1; " Text="Edit" height="26px" width="55px" OnClick="btnEdit_Click"  />
            <asp:Button ID="btnDelete" runat="server"  style="z-index: 1; right: 249px" Text="Delete" height="26px" width="55px" OnClick="btnDelete_Click"/>
        </div>
    </form>
</body>
</html>
