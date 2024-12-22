<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="WebApplication1.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Product List</h1>
            <asp:DropDownList ID="Products" runat="server" AutoPostBack="true" OnSelectedIndexChanged="Products_Selected">
                <asp:ListItem Text="Select a product" Value="0" />
                <asp:ListItem Text="Coke" Value="1" />
                <asp:ListItem Text="Doll" Value="2" />
                <asp:ListItem Text="Make Up" Value="3" />
                <asp:ListItem Text="Shoe" Value="4" />
            </asp:DropDownList>
 
            <br /><br />
            <asp:Image ID="imgProduct" runat="server" Width="200px" CssClass="product-image" Visible="false" />
 
            <br /><br />
            <asp:Button ID="btnGetPrice" runat="server" Text="Get Price" OnClick="btnGetPrice_Click" />
            
            <br /><br />
            <asp:Label ID="labelPrice" runat="server" Text="Price: $" Visible="false" />
        </div>
    </form>
</body>
</html>
