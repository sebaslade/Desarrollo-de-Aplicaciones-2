<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="WebServicioAuto.aspx.cs" Inherits="ClienteWEBNetFramework.WebServicioAuto" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2>CONSULTA DE MULTAS VEHICULARES</h2>
    <table style="width: 80%">
        <tr>
            <td style="width: 311px">Ingrese placa:</td>
            <td>
                <asp:TextBox ID="txtNumPlaca" runat="server" Width="348px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 311px">&nbsp;</td>
            <td>
                <asp:Button ID="btnConsultar" runat="server" Height="31px" OnClick="btnConsultar_Click" Text="Consultar" Width="93px" />
            </td>
        </tr>
        <tr>
            <td style="width: 311px">Multa Acumulada:</td>
            <td>
                <asp:Label ID="lblMulta" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td style="height: 23px; width: 311px">Cantidad de papeletas impagas:</td>
            <td style="height: 23px">
                <asp:Label ID="lblPapeletas" runat="server"></asp:Label>
            </td>
        </tr>
    </table>
    <br />
    <asp:GridView ID="grdPapeletas" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#E7E7FF" BorderStyle="None" BorderWidth="1px" CellPadding="3" GridLines="Horizontal" Height="233px" Width="1233px">
        <AlternatingRowStyle BackColor="#F7F7F7" />
        <Columns>
            <asp:BoundField DataField="num_papeleta" HeaderText="Nro. papeleta" />
            <asp:BoundField DataField="fec_papeleta" DataFormatString="{0:d}" HeaderText="Fec. papeleta" />
            <asp:BoundField DataField="des_infraccion" HeaderText="Infracción" />
            <asp:BoundField DataField="multa" DataFormatString="{0:c}" HeaderText="Multa (S/.)">
            <ItemStyle HorizontalAlign="Right" />
            </asp:BoundField>
        </Columns>
        <FooterStyle BackColor="#B5C7DE" ForeColor="#4A3C8C" />
        <HeaderStyle BackColor="#4A3C8C" Font-Bold="True" ForeColor="#F7F7F7" />
        <PagerStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" HorizontalAlign="Right" />
        <RowStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" />
        <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="#F7F7F7" />
        <SortedAscendingCellStyle BackColor="#F4F4FD" />
        <SortedAscendingHeaderStyle BackColor="#5A4C9D" />
        <SortedDescendingCellStyle BackColor="#D8D8F0" />
        <SortedDescendingHeaderStyle BackColor="#3E3277" />
    </asp:GridView>
    <br />
    <br />

</asp:Content>
