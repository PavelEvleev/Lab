<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewPhotos.aspx.cs" Inherits="UploadsFIle.ViewPhotos" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:GridView ID="gridThumbs" runat="server" AutoGenerateColumns="false" Font-Names="Verdana" Font-Size="X-Small" GridLines="None">
            <Columns>
                <asp:TemplateField>
                    <ItemTemplate>
                        <img src='<%# GetImageUrl(Eval("FullName")) %>' />
                        <%# Eval("Name") %>
                        </hr>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
    </div>
    </form>
</body>
</html>
