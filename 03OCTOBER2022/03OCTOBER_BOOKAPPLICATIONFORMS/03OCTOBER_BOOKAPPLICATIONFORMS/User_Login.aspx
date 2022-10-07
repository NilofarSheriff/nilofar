<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="User_Login.aspx.cs" Inherits="_03OCTOBER_BOOKAPPLICATIONFORMS.User_Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="txtusn" runat="server" Text="UserName"></asp:Label>
&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="usn" runat="server"></asp:TextBox>
        <br />
        <br />
        <br />
        <asp:Label ID="txtpwd" runat="server" Text="Password"></asp:Label>
&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="pwd" runat="server" TextMode="Password"></asp:TextBox>
        <br />
        <br />
        <br />
        <br />
        <asp:Button ID="btnsbt" runat="server" OnClick="btnsbt_Click" Text="Sumbit" />
    </form>
</body>
</html>
