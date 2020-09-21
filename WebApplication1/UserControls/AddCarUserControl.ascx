<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="AddCarUserControl.ascx.cs" Inherits="WebApplication1.UserControls.AddCarUserControl" %>


<table>  
    <tr>  
    <td>Name</td>  
        <td>  
            <asp:TextBox ID="txtModel" runat="server"></asp:TextBox>  
        </td>  
    </tr>  
    <tr>  
        <td>City</td>  
        <td>
            <asp:TextBox ID="txtFuel" runat="server"></asp:TextBox>
        </td>  
    </tr>  
    <tr>  
        <td></td>  
        <td>  
         </td>  
    </tr>  
    <tr>  
        <td></td>  
        <td>   
            <asp:Button ID="txtAdd" runat="server" Text="Add Car" onclick="txtAdd_Click" />
        </td>  
    </tr>  
</table>
<br/>  
 <asp:Label ID="Label1" runat="server"></asp:Label>   