<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="chat1.Register" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div align="center">
        <h1>Register</h1><br />

        <asp:TextBox ID="fname" placeholder="First Name" runat="server"></asp:TextBox>
        <asp:TextBox ID="mname" placeholder="Middle Name" runat="server"></asp:TextBox>
        <asp:TextBox ID="lname" placeholder="Last Name" runat="server"></asp:TextBox>
        <br />
        Designation :
        <asp:DropDownList ID="DropDownList1" runat="server">
            <asp:ListItem>Student</asp:ListItem>
            <asp:ListItem>Professor</asp:ListItem>
            <asp:ListItem>HOD</asp:ListItem>
            <asp:ListItem>Principal</asp:ListItem>
        </asp:DropDownList>
        <br />
        Branch :
        <asp:DropDownList ID="branch" runat="server">
            <asp:ListItem>Mechanical</asp:ListItem>
            <asp:ListItem>Civil</asp:ListItem>
            <asp:ListItem>Electrical</asp:ListItem>
            <asp:ListItem>CSE</asp:ListItem>
            <asp:ListItem>IT</asp:ListItem>
            <asp:ListItem>ENTC</asp:ListItem>
        </asp:DropDownList>
        <br />
        Enrollment no :
        <asp:TextBox ID="enrollno" runat="server"></asp:TextBox>
        <br />
        Password :
        <asp:TextBox ID="password" runat="server"></asp:TextBox>
&nbsp;Confirm Password :
        <asp:TextBox ID="cpassword" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="registerbtn" runat="server" Text="Register" OnClick="registerbtn_Click" />

    </div>
</asp:Content>
