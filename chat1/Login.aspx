<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="chat1.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div align="center">
    <h1>
        Login
    </h1>
    
    <asp:TextBox ID="username" runat="server" placeholder="Username" OnTextChanged="username_TextChanged"></asp:TextBox>
    <br />
    <asp:TextBox ID="password" placeholder="Password" runat="server"></asp:TextBox>
    <br />
    <asp:Button ID="loginbutton" runat="server" Text="Login" OnClick="loginbutton_Click" />
    <br />
    or<br />
    <asp:LinkButton ID="registerbutton" runat="server" OnClick="registerbutton_Click">Register</asp:LinkButton>
    <br />
    <asp:Label ID="ip" runat="server" ForeColor="Red"></asp:Label>
    <br />
    
</div>

</asp:Content>
