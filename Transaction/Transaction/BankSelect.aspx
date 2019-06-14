<%@ Page Language="C#" AutoEventWireup="true" CodeFile="BankSelect.aspx.cs" Inherits="BankSelect" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body  style="background:url(../images/thc.jpg) no-repeat 100% 0;">
    <form id="form1" runat="server">
        <h1>EASY EFT Payment</h1>
        <br><br />
        <br><br />
        <asp:ImageButton class="capitec" ID="capitec" ImageUrl="~/Images/Capitec.jpg" Width="97px" Height="88px" runat="server" OnClick="capitec_Click" /><br><br />
        <asp:ImageButton class="standard" ID="standardBank" ImageUrl="~/Images/StandardBank-(400px-x-400px).png" Width="96px" Height="96px" runat="server" OnClick="standardBank_Click" />
    </form>
</body>
</html>
