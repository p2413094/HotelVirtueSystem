<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ACancellation.aspx.cs" Inherits="ACancellation" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
                <div>
            <asp:Label ID="lblBoookingLineId" runat="server" Text="BookingLineId" Width="200px"></asp:Label>
            &nbsp;<asp:TextBox ID="txtBookingLineId" runat="server" Width="127px" ></asp:TextBox>
            <br />
            <asp:Label ID="lblReason" runat="server" Text="Reason: " Width="100px"></asp:Label>
            &nbsp;<asp:TextBox ID="txtReason" runat="server" ></asp:TextBox>            
            <br />
            <br />
            <asp:Label ID="lblError" runat="server" ></asp:Label>            
            <br />
            <br />
            <asp:Button ID="btnOK" runat="server" height="26px" Text="OK" width="61px" OnClick="btnOK_Click"  />
            <asp:Button ID="btnCancel" runat="server" style="z-index: 1;" Text="Cancel" height="26px" width="61px" OnClick="btnCancel_Click"  />
        </div>
    </form>
</body>
</html>
