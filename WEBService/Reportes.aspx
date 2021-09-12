<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Reportes.aspx.cs" Inherits="WEBService.Reportes" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Reportes</title>
    <link href="Estilos\style.css?v=<%=DateTime.Now%>" rel="stylesheet" />
</head>
<body style="width:100%;height:730px; margin-left: 0px;">
    <form id="form1" runat="server">    
    <div style="height: 590px; width:100%;margin-right: 30px">
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
                <asp:Button ID="btn_Usuarios" class="botones_encabezado" runat="server" Text="Usuarios" OnClick="btn_Usuarios_Click"/>
                <asp:Button ID="btn_Clientes" class="botones_encabezado" runat="server" Text="Clientes" OnClick="btn_Clientes_Click" />
                <asp:Button ID="btn_Marcas" class="botones_encabezado" runat="server" Text="Marcas" OnClick="btn_Marcas_Click" />
                <asp:Button ID="Button6" class="botones_encabezado" runat="server" Text="Categorias" OnClick="Button6_Click"/>
                <asp:Button ID="btn_Productos" class="botones_encabezado" runat="server" Text="Articulos" OnClick="btn_Productos_Click"/>
                <asp:Button ID="btn_Facturacion" class="botones_encabezado" runat="server" Text="Facturacion" OnClick="btn_Facturacion_Click" />
                <asp:Button ID="btn_Reportes" class="botones_encabezado" runat="server" Text="Reportes" BackColor="#0099FF" ForeColor="Black" OnClick="btn_Reportes_Click" />
                <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="Label4" runat="server" BackColor="Black" Font-Size="Large" ForeColor="White" Text="Proyecto Programacion IV"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            </div>  
            </header>
        <div class="contenedor_reportes">
            <br />
               &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <br />
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
             <br />
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
             <asp:Label ID="Label5" runat="server" class="etiqueta_principal" Text="Detalle Facturacion"></asp:Label>
            <br />
            <br />
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:GridView ID="gvDetalle" runat="server" AllowPaging="True" CssClass="mGrid" PagerStyle-CssClass="pgr" AlternatingRowStyle-CssClass="alt" Height="103px" style="margin-left: 130px; margin-top: 0px" Width="465px" AutoGenerateColumns="false">
<AlternatingRowStyle CssClass="alt"></AlternatingRowStyle>
                 <Columns>   
                    <asp:BoundField HeaderText="Nombre cliente" DataField="nombreCliente" />                       
                    <asp:BoundField HeaderText="Nombre articulo" DataField="nombreArticulo" /> 
                    <asp:BoundField HeaderText="Marca" DataField="marca" />
                     <asp:BoundField HeaderText="Categoria" DataField="categoria" />
                    <asp:BoundField HeaderText="Cantidad" DataField="cantidad" />      
                     <asp:BoundField HeaderText="Total" DataField="total" />  
                  </Columns>
             </asp:GridView>
            </div>
  </div>
    </form>
</body>
</html>