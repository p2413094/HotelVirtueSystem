<%@ Page Language="C#" AutoEventWireup="true" CodeFile="APayment.aspx.cs" Inherits="APayment" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
                <div>
                        <asp:Label ID="lblCustomerId" runat="server" Text="CustomerId" Width="200px"></asp:Label>
            &nbsp;<asp:TextBox ID="txtCustomerId" runat="server" Width="127px" ></asp:TextBox>
            <br />
            <asp:Label ID="lblBookingLineId" runat="server" Text="BookingLineId" Width="200px"></asp:Label>
            &nbsp;<asp:TextBox ID="txtBookingLineId" runat="server" ></asp:TextBox>
            <br />
            <asp:Label ID="lblAmount" runat="server"  Text="Amount" Width="100px"></asp:Label>
            &nbsp;<asp:TextBox ID="txtAmount" runat="server" ></asp:TextBox>
            <br />
            <asp:Label ID="lblCardNumber" runat="server" Text="Card number" Width="100px"></asp:Label>
            &nbsp;<asp:TextBox ID="txtCardNumber" runat="server" ></asp:TextBox>
            <br />
            <asp:Label ID="lblNameOnCard" runat="server" Text="Name on card" Width="200px"></asp:Label>
            &nbsp;<asp:TextBox ID="txtNameOnCard" runat="server" ></asp:TextBox>
            <br />
            <asp:Label ID="lblExpiryDate" runat="server" Text="Expiry date" Width="200px"></asp:Label>
            &nbsp;<asp:TextBox ID="txtExpiryDate" runat="server" ></asp:TextBox>
            <br />
             <asp:Label ID="lblSecurityCode" runat="server" Text="Security code" Width="200px"></asp:Label>
            &nbsp;<asp:TextBox ID="txtSecurityCode" runat="server" ></asp:TextBox>
            <br />
            <asp:Label ID="lblCardType" runat="server" Text="Card type" Width="200px"></asp:Label>
            &nbsp;<asp:TextBox ID="txtCardType" runat="server" ></asp:TextBox>
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
