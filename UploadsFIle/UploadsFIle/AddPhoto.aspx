<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddPhoto.aspx.cs" Inherits="UploadsFIle.AddPhoto" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" enctype="multipart/form-data" method="post" runat="server" >
    <div>
    <INPUT type=file id=File1 name=File1 runat="server" /> <br>
    <input type="submit" id="Submit1" value="Upload" runat="server"/>
        <a href="ViewPhotos.aspx">Show All Image</a>
    </div>
    </form>
</body>
</html>
