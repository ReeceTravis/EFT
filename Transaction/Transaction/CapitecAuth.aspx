<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CapitecAuth.aspx.cs" Inherits="CapitecAuth" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="background:url(../images/thc.jpg) no-repeat 100% 0;">
    <form id="form1" runat="server">
        <h1>Easy EFT Payment</h1>
        <asp:Label ID="Label1" runat="server" Text="Enter Capitec Account Number/Username"></asp:Label><br><br />
        <asp:TextBox ID="email_Address" runat="server"></asp:TextBox>
        <br><br />
        <asp:Label ID="Label2" runat="server" Text="Capitec Password/Remote PIN"></asp:Label><br><br />
        <asp:TextBox ID="passWord" runat="server" CausesValidation="True" TextMode="Password"></asp:TextBox>
        <br><br />
&nbsp;<asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Submit" />
    </form>
</body>
</html>
