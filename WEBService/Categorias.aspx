<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Categorias.aspx.cs" Inherits="WEBService.Categorias" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Categorias</title>
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
                <asp:Button ID="Button6" class="botones_encabezado" runat="server" Font-Size="Large" BackColor="#0099FF" ForeColor="Black" Text="Categorias" OnClick="Button6_Click"/>
                <asp:Button ID="btn_Productos" class="botones_encabezado" runat="server" Text="Articulos" OnClick="btn_Productos_Click"/>
                <asp:Button ID="btn_Facturacion" class="botones_encabezado" runat="server" Text="Facturacion" OnClick="btn_Facturacion_Click" />
                <asp:Button ID="btn_Reportes" class="botones_encabezado" runat="server" Text="Reportes" OnClick="btn_Reportes_Click" />
                <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="Label4" runat="server" CssClass="encabezado_secundario" Text="Proyecto Programacion IV"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            </div>
            </header>
         <div class="contenedor_principal-categorias">
             <div style="height: 448px">
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <br />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
             <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
             <asp:Label ID="Label5" runat="server" class="etiqueta_principal" Text="Categorias"></asp:Label>
                    <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <br />
             <br />
             &nbsp;<asp:GridView ID="gvCategorias" runat="server" AllowPaging="True" CssClass="mGrid" PagerStyle-CssClass="pgr" AlternatingRowStyle-CssClass="alt" Height="103px" style="margin-left: 72px; margin-top: 0px" Width="445px" AutoGenerateColumns="False" OnRowCancelingEdit="gvCategorias_RowCancelingEdit" OnRowDeleting="gvCategorias_RowDeleting" OnRowEditing="gvCategorias_RowEditing" OnRowUpdating="gvCategorias_RowUpdating" >
<AlternatingRowStyle CssClass="alt"></AlternatingRowStyle>
                 <Columns>   
                    <asp:BoundField HeaderText="Id" DataField="id" />
                    <asp:BoundField HeaderText="Nombre" DataField="nombre" />
                    <asp:BoundField HeaderText="Descripción" DataField="descripcion" />   
                    <asp:CommandField DeleteText="Eliminar" ShowDeleteButton="true" 
                          ButtonType="Link"/>
                     <asp:CommandField EditText="Editar" ShowEditButton="true" 
                         ButtonType="Link" /> 
                  </Columns>

<PagerStyle CssClass="pgr"></PagerStyle>
             </asp:GridView>
                </div>
             <div id="ocultar" class="formulario_categorias">
                 <asp:Label ID="Label7" runat="server" Font-Size="XX-Large" ForeColor="#666666" Text="Formulario categorias" Width="400px"></asp:Label>
                 <div class="formulario_categorias-secundario">  
                            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<br />
&nbsp;&nbsp;&nbsp; &nbsp;<br />
                            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                            <asp:Label ID="Label2" runat="server" Font-Size="X-Large" Text="Nombre:"></asp:Label>
                            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;<asp:TextBox ID="txtNombre" class="textbox-form" runat="server" Width="188px"></asp:TextBox>
                            <br />
                            <br />
                            <br />
                            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                            <asp:Label ID="Label8" runat="server" Font-Size="X-Large" Text="Descripcion:"></asp:Label>
                            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:TextBox ID="txtDescripcion" class="textbox-form" runat="server" Width="188px" style="margin-left: 0px"></asp:TextBox>
                            &nbsp;&nbsp;&nbsp;&nbsp;
                            <br />
                            <br />
                            <br />
                            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp; &nbsp;&nbsp;&nbsp;
                            <br />
                            <br />
                            <br />
                            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                            <br />
                            <br />
                            <br />                                       
                 </div>
                            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                            
                            <asp:Button ID="btnAgregar" runat="server" CssClass="botones_encabezado" BackColor="#CCCCCC" ForeColor="Black" Text="Agregar categoria" Font-Size="Large" style="margin-left: 151px" Width="190px" OnClick="btnAgregar_Click"/>
             </div>             
    </div>
  </div>
    </form>
</body>
</html>

