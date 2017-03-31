<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="SumTwoTextBox.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:TextBox ID="x1" runat="server" Width="110px"></asp:TextBox>
&nbsp;+
        <asp:TextBox ID="x2" runat="server" Width="153px"></asp:TextBox>
&nbsp;=
        <asp:Label ID="ResultSum" runat="server" Text="Result"></asp:Label>
&nbsp;<br />
        <br />
        <asp:Button ID="SumButton" runat="server" Text="Sum" OnClick="SumButton_Click" />
    
    </div>
    </form>
</body>
</html>
