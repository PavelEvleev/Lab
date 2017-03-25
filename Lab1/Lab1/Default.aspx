<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Lab1._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <asp:Literal ID="LiteralLogin" runat="server">Login</asp:Literal>
    <asp:TextBox ID="Login" runat="server"></asp:TextBox>
    <br />
    <asp:Literal ID="LiteralPassword" runat="server">Password</asp:Literal>
    <asp:TextBox ID="Password" runat="server"></asp:TextBox>
    <br />
    <asp:Button ID="Send" runat="server" Text="Enter" OnClick="Send_Click" /> 

</asp:Content>
