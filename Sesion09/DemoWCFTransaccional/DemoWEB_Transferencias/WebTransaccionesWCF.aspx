<%@ Page Title="" Language="C#" MasterPageFile="~/DemoMaster.Master" AutoEventWireup="true" CodeBehind="WebTransaccionesWCF.aspx.cs" Inherits="DemoWEB_Transferencias.WebTransaccionesWCF" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" tagPrefix="ajaxToolkit" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Cabecera" runat="server">
    <style type="text/css">
    .auto-style1 {
        width: 70%;
    }
    .auto-style2 {
        width: 274px;
    }
        .auto-style4 {
            width: 70%;
            text-align: right;
        }
        .auto-style5 {
            font-family: Verdana;
            font-size: 10pt;
            color: #993366;
            height: 26px;
        }
        .auto-style6 {
            height: 26px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Principal" runat="server">
    <p class="tituloForm">Demo Transacciones con WCF</p>
    <asp:UpdatePanel runat="server" ID="UpdatePanel1">
         <ContentTemplate >
    <table class="auto-style1">
        <tr>
            <td class="labelContenido">Ingrese cliente empresa 1:</td>
            <td>
                <asp:TextBox ID="txtCodCliente1" runat="server"></asp:TextBox>
&nbsp;</td>
        </tr>
        <tr>
            <td class="labelContenido">Ingrese cliente empresa 2:</td>
            <td>
                <asp:TextBox ID="txtCodCliente2" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style5">Ingrese monto a transferir:</td>
            <td class="auto-style6">
                <asp:TextBox ID="txtMonto" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td>
                <asp:Button ID="btnTransferir" runat="server" Text="Transferir" OnClick="btnTransferir_Click" CssClass="boton2" />
            &nbsp;&nbsp;
            </td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
</table>
             <%--CONFIGURACION DEL MODALPOPUP DE MENSAJES --%>
                <%--Paso 1: Control target (puede ser cualquier control)--%>
              <asp:LinkButton ID="lnkMensaje" runat="server" ></asp:LinkButton>
                 <%--Paso 2: El panel cuyo contenido se mostrara en el popup--%>
              <asp:Panel ID="pnlMensaje" runat="server" CssClass="CajaDialogo" Style="display: normal;" Width="500"> 
                    <table border="0" width="500px" style="margin: 0px; padding: 0px; background-color:darkred ; 
                        color: #FFFFFF;"> 
                        <tr> 
                            <td align="center"  width="88%"> 
                                <asp:Label ID="lblTitulo" runat="server" Text="Mensaje" /> 
                            </td> 
                            <td width="12%" class="auto-style4" > 
                                <asp:ImageButton ID="btnCerrar" runat="server" ImageUrl="~/Images/Cancelar.png" Style="vertical-align: top;" 
                                    ImageAlign="Right" /> 
                            </td> 
                        </tr> 
                         
                    </table>
                    <div> 
                        <asp:Label ID="lblMensajePopup" runat="server" ForeColor ="Black" CssClass="labelTitulo" /> 
                    </div>
                     <div>
                         <br />
                     </div>
                    <div> 
                        <asp:Button ID="btnAceptar" runat="server" Text="Aceptar" CssClass="boton" /> 
                    </div> 
                  <div>
                         <br />
                     </div>
                </asp:Panel> 
          <%--Paso 3:  El ModalPopup de AJAX Toolkit que hace referencia al ID del control target del paso 1  (TargetControlID="lnkMensaje")
                    y al ID del panel definido en el paso 2 (PopupControlID="pnlMensaje")--%>
                <ajaxToolkit:ModalPopupExtender ID="PopMensaje" runat="server" TargetControlID="lnkMensaje" 
                    PopupControlID="pnlMensaje" BackgroundCssClass="FondoAplicacion"  OkControlID="btnAceptar" />


  </ContentTemplate>
 </asp:UpdatePanel>
  <%--  Aqui configuramos el UpdateProgress para que muestre el contenido del ProgressTemplate todo el tiempo que demore en actualizarse
           el UpdatePanel definido en la propiedad AssociatedUpdatePanelID (en este caso el UpdatePanel1.
          NOTA: Recuerde descomentar el codigo contenido dentro del  ProgressTemplate antes de probar el formulario --%>
  <asp:UpdateProgress ID="UpdateProgress1" runat="server" 
      DisplayAfter="0" AssociatedUpdatePanelID="UpdatePanel1">
          <ProgressTemplate>
              <div class="overlay">
                <div class="overlayContent ">
                  <h2>Espere un momento....</h2>  
                  <img src ="../Images/loading.gif" alt ="Loading" border="0"/>      
               </div>
              </div>
          </ProgressTemplate>
   </asp:UpdateProgress>
</asp:Content>

