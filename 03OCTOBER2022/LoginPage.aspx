<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginPage.aspx.cs" Inherits="_30sept_1_username_password.LoginPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="usn" runat="server" Text="UserName"></asp:Label>
&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtusn" runat="server" MaxLength="10"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="pwdid" runat="server" Text="Password"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtpwd" runat="server" TextMode="Password"></asp:TextBox>
        <p>
            &nbsp;</p>
        <asp:Button ID="sbm" runat="server" OnClick="Page_Load" Text="Sumbit" />
        <br />
        <br />
        <p>
            <asp:Label ID="lbler" runat="server" ForeColor="Red"></asp:Label>
            <asp:Label ID="lbler0" runat="server" ForeColor="Green"></asp:Label>
        </p>
    </form>
</body>
</html>
