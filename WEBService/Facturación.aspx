<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Facturación.aspx.cs" Inherits="WEBService.Facturación" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Facturacion</title>
    <link href="Estilos\style.css?v=<%=DateTime.Now%>" rel="stylesheet" />
</head>
<body style="width: 100%; height: 530px; margin-left: 0px;">
    <form id="form1" runat="server">        
            <div style="height: 590px; width: 100%; margin-right: 30px">
                <header>
                <div class="contenedor_encabezado">
                    <br />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <br />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <br />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="Label3" runat="server" class="encabezado_principal" Text="Sistema de Facturacion y Control de Inventario"></asp:Label>
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="btn_Usuarios" class="botones_encabezado" runat="server" Text="Usuarios" OnClick="btn_Usuarios_Click" />
                    <asp:Button ID="btn_Clientes" class="botones_encabezado" runat="server" Text="Clientes" OnClick="btn_Clientes_Click" />
                    <asp:Button ID="btn_Marcas" class="botones_encabezado" runat="server" Text="Marcas" OnClick="btn_Marcas_Click" />
                    <asp:Button ID="Button6" class="botones_encabezado" runat="server" Text="Categorias" OnClick="Button6_Click" />
                    <asp:Button ID="btn_Productos" class="botones_encabezado" runat="server" Text="Articulos" OnClick="btn_Productos_Click" />
                    <asp:Button ID="btn_Facturacion" class="botones_encabezado" runat="server" BackColor="#0099FF" ForeColor="Black" Text="Facturacion" OnClick="btn_Facturacion_Click" />
                    <asp:Button ID="btn_Reportes" class="botones_encabezado" runat="server" Text="Reportes" OnClick="btn_Reportes_Click" />
                    <br />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="Label4" runat="server" CssClass="encabezado_secundario" Text="Proyecto Programacion IV"></asp:Label>
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                </div>
                    </header>
                <div class="contenedor_principal-usuarios">
                    <div style="height: 448px">
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <br />
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
             <br />
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
             <asp:Label ID="Label5" runat="server" class="etiqueta_principal" Text="Facturacion"></asp:Label>
                        <br />
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <br />
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
             <br />
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
             <asp:Label ID="Label6" runat="server" Font-Size="X-Large" Text="Facturar a:"></asp:Label>
                        &nbsp;&nbsp;
                <asp:DropDownList ID="dp_Clientes" class="textbox-form" runat="server" AutoPostBack="True">
                </asp:DropDownList>
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="Label11" runat="server" Font-Size="X-Large" Text="Cantidad:"></asp:Label>
                        &nbsp;&nbsp;
                <asp:TextBox ID="txtCantidad" class="textbox-form" runat="server" TextMode="Number" Width="60px"></asp:TextBox>
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="Label10" runat="server" Font-Size="X-Large" Text="Fecha:"></asp:Label>
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="txtFecha" class="textbox-form" runat="server" Format="dd/mm/yyyy" TextMode="Date" Width="172px"></asp:TextBox>
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
             <br />
                        <br />
                        &nbsp;<asp:GridView ID="gvFacturas" runat="server" AllowPaging="True" CssClass="mGrid" PagerStyle-CssClass="pgr" AlternatingRowStyle-CssClass="alt" Height="103px" Style="margin-left: 72px; margin-top: 0px" Width="445px" AutoGenerateColumns="False" OnSelectedIndexChanged="gvFacturas_SelectedIndexChanged" OnRowDeleting="gvFacturas_RowDeleting">
<AlternatingRowStyle CssClass="alt"></AlternatingRowStyle>
                            <Columns>
                                <asp:CommandField ShowSelectButton="True" />
                                <asp:BoundField HeaderText="ID" DataField="id" />
                                <asp:BoundField HeaderText="Precio" DataField="precio" />
                                <asp:BoundField HeaderText="Nombre" DataField="nombre" />
                                <asp:BoundField HeaderText="Descripción" DataField="Descripcion" />
                                <asp:BoundField HeaderText="Marca" DataField="marca.nombre" />
                                <asp:BoundField HeaderText="Categoria" DataField="categoria.nombre" />
                                <asp:CommandField DeleteText="Eliminar" ShowDeleteButton="true"
                                    ButtonType="Link" />                          
                            </Columns>
                        </asp:GridView>
                    </div>
                    <div id="ocultar" runat="server" class="formulario_facturacion">
                        <asp:TextBox ID="txtidProducto" runat="server" Width="16px" Height="16px"></asp:TextBox>
                        <br />
                        <asp:Label ID="Label7" runat="server" Font-Size="XX-Large" ForeColor="#666666" Text="Producto a facturar" Width="400px" style="margin-left: 13px"></asp:Label>
                        <div class="formulario_facturacion-producto">
                            &nbsp;&nbsp;
                            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                            <asp:Label ID="Label12" runat="server" Font-Size="X-Large" Text="Producto:"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                            <asp:TextBox ID="txtProducto" class="textbox-form" runat="server" Width="188px" Enabled="true" ReadOnly="True"></asp:TextBox>
                            <br />
                            <br />
                            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                            <asp:Label ID="Label13" runat="server" Font-Size="X-Large" Text="Precio:"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                            <asp:TextBox ID="txtPrecio" class="textbox-form" runat="server" Width="188px" ReadOnly="True"></asp:TextBox>
                            <br />
                            <br />
                            <br />
&nbsp;&nbsp;&nbsp;
                            <br />                                                       
                            &nbsp;&nbsp;&nbsp; &nbsp;                                 
                        </div>               
                        <br /> 
                        <div style="width: 436px">
                            <asp:Button ID="btnagregarP" CssClass="botones_encabezado" runat="server" BackColor="#CCCCCC" ForeColor="Black" Text="Agregar" Font-Size="Large" Style="margin-left: 95px" Width="100px" OnClick="btnagregarP_Click"/>
                       
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                       
                        <asp:Button ID="btnCancelarP" runat="server" CssClass="botones_encabezado" BackColor="#CCCCCC" Font-Size="Large" Width="100px" ForeColor="Black" Text="Cancelar" OnClick="btnCancelarP_Click" />
                        </div>
                        
                        <br />    
                        <asp:Label ID="Label9" runat="server" Font-Size="XX-Large" ForeColor="#666666" Text="Detalle facturacion" Width="400px" style="margin-left: 17px"></asp:Label>
                        <div class ="formulario_facturacion-secundario"> 
                            <br /> 
                            &nbsp;&nbsp;&nbsp;
                            <asp:Label ID="Label1" runat="server" Font-Size="X-Large" Text="SubTotal:"></asp:Label>
                            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
                            <asp:TextBox ID="txtSubtotal" class="textbox-form" runat="server" Width="188px" ReadOnly="True"></asp:TextBox>
                            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                            <br />
                            <br />
                            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
                            <asp:Label ID="Label2" runat="server"  Font-Size="X-Large" Text="IVA:"></asp:Label>
                            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:TextBox ID="txtIVA" class="textbox-form" runat="server" Width="188px" ReadOnly="True">0.13</asp:TextBox>
                            <br />
                            <br />
                            <br />
                            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                            <asp:Label ID="Label8" runat="server" Font-Size="X-Large" Text="Total:"></asp:Label>
                            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;
                            <asp:TextBox ID="txtTotal" class="textbox-form" runat="server" Width="188px"></asp:TextBox>
                            <br />
                            <br />
                            <br />
                            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp    
                            <br />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</div>
                      &nbsp;<asp:Button ID="btnAgregar" CssClass="botones_encabezado" runat="server" BackColor="#CCCCCC" ForeColor="Black" Text="Facturar" Font-Size="X-Large" Style="margin-left: 151px" Width="190px" OnClick="btnAgregar_Click" />
                    </div>
                       
                </div>
            </div>        
    </form>
</body>
</html>