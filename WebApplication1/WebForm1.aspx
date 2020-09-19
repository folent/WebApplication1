<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>WebForms</title>
</head>
 
<body>
    <style type="text/css">
        .titleTable {
            background-color: grey;
            color: white;
            font-weight: bold;
        }
    </style>
    <h1>WebForms</h1>
    <form runat="server">
            <table >
                <tr>
                   <th class="titleTable">Model</th>
                   <th class="titleTable">Fuel</th>
                </tr>
                    <asp:Label ID="data_table" runat="server"></asp:Label>
            </table>
            <asp:LinkButton OnClick="show_fuel" runat="server">Show fuels</asp:LinkButton>

    </form>
    <asp:Label ID="fuels" runat="server"></asp:Label>
    <a href="WebForm2.aspx" >Больше информации об автомобилях</a>
</body>
</html>
