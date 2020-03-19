<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ARoom.aspx.cs" Inherits="ARoom" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            height: 570px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Button ID="lblEdit" runat="server" OnClick="lblEdit_Click" style="z-index: 1; left: 318px; top: 293px; position: absolute" Text="Edit" />
        <asp:ListBox ID="lstRooms" runat="server" style="z-index: 1; left: 131px; top: 168px; position: absolute"></asp:ListBox>
        <p>
            &nbsp;</p>
        <p>
            <asp:CheckBox ID="chkAccessible" runat="server" style="z-index: 1; left: 555px; top: 299px; position: absolute" Text="Accessible" />
        </p>
        <asp:Label ID="lblPrice" runat="server" style="z-index: 1; left: 545px; top: 350px; position: absolute; height: 29px" Text="Price:"></asp:Label>
        <asp:TextBox ID="txtPrice" runat="server" style="z-index: 1; left: 589px; top: 345px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblRoomFloor" runat="server" style="z-index: 1; left: 545px; top: 379px; position: absolute" Text="Room Floor:"></asp:Label>
        <asp:TextBox ID="txtRoomFloor" runat="server" style="z-index: 1; left: 635px; top: 374px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblRoomNumber" runat="server" style="z-index: 1; left: 541px; top: 401px; position: absolute; height: 25px" Text="Room Number:"></asp:Label>
        <asp:TextBox ID="txtRoomNumber" runat="server" style="z-index: 1; left: 640px; top: 401px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblRoomTypeId" runat="server" style="z-index: 1; left: 541px; top: 427px; position: absolute" Text="Room Type Id:"></asp:Label>
        <asp:TextBox ID="txtRoomTypeId" runat="server" style="z-index: 1; left: 640px; top: 427px; position: absolute"></asp:TextBox>
        <asp:CheckBox ID="chkAvailable" runat="server" style="z-index: 1; left: 636px; top: 453px; position: absolute" Text="Available" />
        <asp:Label ID="lblHotelId" runat="server" style="z-index: 1; left: 547px; top: 320px; position: absolute" Text="Hotel Id:"></asp:Label>
        <asp:TextBox ID="txtHotelId" runat="server" style="z-index: 1; left: 608px; top: 319px; position: absolute"></asp:TextBox>
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" style="z-index: 1; left: 537px; top: 499px; position: absolute" Text="OK" />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 542px; top: 473px; position: absolute"></asp:Label>
        <asp:Button ID="btnCancel" runat="server" OnClick="btnCancel_Click" style="z-index: 1; left: 616px; top: 501px; position: absolute" Text="Cancel" />
    </form>
</body>
</html>
