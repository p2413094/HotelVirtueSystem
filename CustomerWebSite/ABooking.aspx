<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ABooking.aspx.cs" Inherits="ABooking" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblRoomId" runat="server" Text="RoomId" Width="100px"></asp:Label>
            &nbsp;<asp:TextBox ID="txtRoomId" runat="server" Width="127px" ></asp:TextBox>
            <br />
            <asp:Label ID="lblUnderFive" runat="server" Text="Under five: " Width="100px"></asp:Label>
            &nbsp;<asp:TextBox ID="txtUnderFive" runat="server" ></asp:TextBox>
            <br />
            <asp:Label ID="lblFiveToSixteen" runat="server"  Text="Five to sixteen" Width="100px"></asp:Label>
            &nbsp;<asp:TextBox ID="txtFiveToSixteen" runat="server" ></asp:TextBox>
            <br />
            <asp:Label ID="lblSixteenUpwards" runat="server" Text="Sixteen upwards: " Width="100px"></asp:Label>
            &nbsp;<asp:TextBox ID="txtSixteenUpwards" runat="server" ></asp:TextBox>
            <br />
            <asp:Label ID="lblArrivalDate" runat="server" Text="Arrival date: " Width="100px"></asp:Label>
            &nbsp;<asp:TextBox ID="txtArrivalDate" runat="server" ></asp:TextBox>
            <br />
            <asp:Label ID="lblDepartureDate" runat="server" Text="Departure date: " Width="100px"></asp:Label>
            &nbsp;<asp:TextBox ID="txtDepartureDate" runat="server" ></asp:TextBox>
            <br />
            <br />
            <asp:CheckBox ID="chkGymAccess" runat="server" style="z-index: 1;" Text="Gym access" />
            <br />
            <br />
            <asp:CheckBox ID="chkLateCheckout" runat="server" style="z-index: 1;" Text="Late checkout" />
            <br />
            <br />
            <asp:Label ID="lblOther" runat="server" Text="Other: " Width="100px"></asp:Label>
            &nbsp;<asp:TextBox ID="txtOther" runat="server" ></asp:TextBox>
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
