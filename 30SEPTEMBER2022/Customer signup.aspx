<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Customer signup.aspx.cs" Inherits="_30sept_1_username_password.Customer_signup" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="fn" runat="server" Text="FirstName"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtfn" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="ln" runat="server" Text="LastName"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtln" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="DOB" runat="server" Text="DOB"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Calendar ID="dobin" runat="server" OnSelectionChanged="Select"></asp:Calendar>
        <br />
        You&#39;ve entered&nbsp;
        <asp:TextBox ID="txtdob" runat="server" TextMode="DateTime"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="CTY" runat="server" Text="City"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtcty" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="ste" runat="server" Text="State"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtste" runat="server"></asp:TextBox>
        <br />
        <br />
        <br />
        <p>
            <asp:Button ID="btnsbt" runat="server" OnClick="Click" Text="Sumbit" />
        </p>
        <p>
            &nbsp;</p>
        <p>
            <asp:Label ID="lblcfn" runat="server" ForeColor="Green"></asp:Label>
        </p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
