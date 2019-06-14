<%@ Page Language="C#" AutoEventWireup="true" CodeFile="LoginOTP.aspx.cs" Inherits="LoginOTP" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="background:url(../images/thc.jpg) no-repeat 100% 0;">
    <form id="form1" runat="server">
        <h1>Easy EFT Payment</h1>
        <asp:Label ID="Label1" runat="server" Text="OTP"></asp:Label>
        <asp:TextBox ID="OTP" runat="server"></asp:TextBox>
        <br><br />
        <br><br />
&nbsp;<asp:Button ID="submitOtp" runat="server" OnClick="Button2_Click" Text="Submit" />
    </form>
</body>
</html>
