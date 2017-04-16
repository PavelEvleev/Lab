<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ChatTamplate.WebForm1" %>

<%@ Register Src="~/UserControl.ascx" TagPrefix="uc1" TagName="UserControl" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <asp:ListView ID="ListUsers" runat="server">
            <ItemTemplate>
                <div class="user">
                     <uc1:UserControl runat="server" ID="UserControl" NameU='<%# Eval("Name") %>' ImgU='<%# Eval("ImageUser") %>' />
                </div>
            </ItemTemplate>
        </asp:ListView>
</asp:Content>
