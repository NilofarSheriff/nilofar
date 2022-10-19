<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="WebApplicationSpecflow.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="u1" runat="server" Text="Username"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="utext" runat="server"></asp:TextBox>
        <br />
        <br />
        <br />
        <asp:Label ID="p1" runat="server" Text="Password"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="ptext" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="sbt" runat="server" OnClick="sbt_Click" Text="Sumbit" />
        <br />
    </form>
</body>
</html>
