<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication1.WebForm1" %>
<%@ Register TagPrefix="uc" TagName="AddCar" Src="~/UserControls/AddCarUserControl.ascx" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>WebForms</title>
</head>
 
<body>
    <h1>WebForms</h1>
    <div style="display:flex;justify-content:space-between;width:500px">
        <div>
            <button id="btn1">Get Cars</button>
            <table id="cars"></table>
        </div>
        <div>
            <button id="btn2">Show fuels</button>
            <table id="fuels" runat="server"></table>
        </div>
    </div>
        <form runat="server">
        <uc:AddCar ID="AddCar" runat="server" />
    </form>
    <a href="WebForm2.aspx" >Больше информации об автомобилях</a>
</body>
    <script src="Ajax/script.js"></script>
</html>
