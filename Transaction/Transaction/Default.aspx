<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server" >

    <div class="jumbotron" style="background:url(../images/thc.jpg) no-repeat 100% 0;">
        <h1>Easy EFT Payment</h1>
        <asp:Label ID="Label1" runat="server" Text="Email Address:"></asp:Label>
        <asp:TextBox ID="email_Address" runat="server"></asp:TextBox>
        <br><br />
        <asp:Label ID="Label2" runat="server" Text="Password:" ></asp:Label>
        <asp:TextBox ID="passWord" runat="server" TextMode="Password"></asp:TextBox>
       <br />
        <br />
        <asp:Label ID="Label3" runat="server" Text="Recipient Email Address:"></asp:Label>
        <asp:TextBox ID="recEmail" runat="server"></asp:TextBox>
        <br><br />
&nbsp;<asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Submit" />
    </div>
    
</asp:Content>
