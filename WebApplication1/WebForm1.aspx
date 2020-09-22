<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication1.WebForm1" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link href="Content/bootstrap.css" rel="stylesheet" />
    <title>WebForms</title>
</head>
 
<body>
    <h1 class="display-1 text-center">WebForms</h1>
     <hr class="my-4">
    <div class="d-flex justify-content-center">
    <div>
        <button class="btn btn-outline-info" id="btn1">Get Cars</button>
        <table class="table table-bordered" id="cars"></table>
    </div>
    <div>
        <button class="btn btn-outline-info" id="btn2">Show fuels</button>
        <table class="table table-bordered" id="fuels"></table>
    </div>
</div>
    <asp:Panel ID="Panel1" runat="server" class="d-flex justify-content-center"></asp:Panel>
    <a href="WebForm2.aspx" class="btn btn-secondary btn-lg btn-block fixed-bottom">Больше информации об автомобилях</a>
</body>
    <script src="Ajax/script.js"></script>
</html>
