<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="MasterPageDemo.WebForm2" %>
<%@ MasterType VirtualPath="~/Site1.Master" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Panel ID="pnlLogin" runat="server">
        <p>
            Web Form 2: Please enter your credentials to login
        </p>
        <asp:Literal ID="literalUsername" Text="Username:" runat="server"></asp:Literal>
        <asp:TextBox ID="txtUserName" runat="server"></asp:TextBox>
        <br />
        <asp:Literal ID="literalPassword" Text="Password:" runat="server"></asp:Literal>
        <asp:TextBox ID="txtPassword" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="btnSubmit" Text="Login" runat="server" OnClick="btnSubmit_Click" />
        <br />
        <asp:Label ID="lblErrorMessage" Text="Please enter valid combination of username and password" runat="server" ForeColor="Red" Visible="false"></asp:Label>
    </asp:Panel>
    <asp:Panel ID="pnlWelcome" runat="server">
        <h1>Profile:</h1>
    </asp:Panel>
</asp:Content>
