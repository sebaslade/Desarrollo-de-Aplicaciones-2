<%@ Page Title="" Language="C#" MasterPageFile="~/DemoMaster.master" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebTestWCF_Infracciones.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
    .auto-style1 {
        width: 70%;
    }
    .auto-style6 {
        height: 22px;
    }
    .auto-style7 {
        width: 338px;
    }
    .auto-style8 {
        width: 338px;
        height: 22px;
    }
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p class="tituloForm">TEST DE ESTADISTICA ANUAL DE INFRACCIONES</p>
    &nbsp;&nbsp;&nbsp;
<table class="auto-style1">
    <tr>
        <td class="labelContenido">Ingrese año:</td>
        <td class="auto-style7">
            <asp:TextBox ID="txtAño" runat="server" CssClass="TextBoxDerecha" Width="170px"></asp:TextBox>
        </td>
        <td>
            <asp:Button ID="btnConsultar" runat="server" CssClass="boton2" Text="Consultar" Width="138px" OnClick="btnConsultar_Click" />
        </td>
    </tr>
    <tr>
        <td class="labelContenido">Ingrese placa:</td>
        <td class="auto-style8">
            <asp:TextBox ID="txtPlaca" runat="server" CssClass="TextBoxDerecha" Width="169px"></asp:TextBox>
        </td>
        <td class="auto-style6"></td>
    </tr>
    <tr>
        <td colspan="3">
            <asp:Label ID="lblMensaje" runat="server" CssClass="labelErrores"></asp:Label>
        </td>
    </tr>
</table>
<br />
<asp:GridView ID="grvDatos" runat="server" BackColor="#DEBA84" BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" CellPadding="3" CellSpacing="2" Width="1274px">
    <FooterStyle BackColor="#F7DFB5" ForeColor="#8C4510" />
    <HeaderStyle BackColor="#A55129" Font-Bold="True" ForeColor="White" />
    <PagerStyle ForeColor="#8C4510" HorizontalAlign="Center" />
    <RowStyle BackColor="#FFF7E7" ForeColor="#8C4510" />
    <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="White" />
    <SortedAscendingCellStyle BackColor="#FFF1D4" />
    <SortedAscendingHeaderStyle BackColor="#B95C30" />
    <SortedDescendingCellStyle BackColor="#F1E5CE" />
    <SortedDescendingHeaderStyle BackColor="#93451F" />
</asp:GridView>

</asp:Content>
