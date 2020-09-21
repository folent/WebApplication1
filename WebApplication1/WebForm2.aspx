<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="WebApplication1.WebForm2" %>
<%@ Register TagPrefix="uc" TagName="CarsDetails" Src="~/UserControls/CarsDetailsUserControl.ascx" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <uc:CarsDetails ID="CarsDetails" runat="server" />
    <a href="WebForm1.aspx" >Назад</a>
</body>
</html>
