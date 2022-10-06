<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Nwndsample.aspx.cs" Inherits="_30sept_1_username_password.Nwndsample" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="pid" runat="server" Text="Product Id"></asp:Label>
&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <br />
        <br />
        <br />
        <asp:Button ID="btn" runat="server" OnClick="select" Text="Sumbit" />
        <p>
            <asp:Label ID="grl" runat="server"></asp:Label>
        </p>
        <p>
            &nbsp;</p>
        <p>
            <asp:Button ID="Btnadd" runat="server" OnClick="add" Text="Add" />
        </p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <asp:ListBox ID="ListBox1" runat="server" DataSourceID="SqlDataSource1" DataTextField="ProductID" DataValueField="ProductID"></asp:ListBox>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:NorthwindConnectionString %>" SelectCommand="SELECT [ProductID] FROM [Alphabetical list of products]"></asp:SqlDataSource>
    </form>
    <p>
        &nbsp;</p>
</body>
</html>
