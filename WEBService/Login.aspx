<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="WEBService.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login</title>
    <link href="Estilos\style.css?v=<%=DateTime.Now%>" rel="stylesheet" />
</head>
<body>
    <form id="form2" runat="server">
        <header>
            <div class="contenedor_encabezado">
                <br />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <br />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <br />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="Label3" class="encabezado_principal" runat="server" Text="Sistema de Facturacion y Control de Inventario"></asp:Label>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="btn_Usuarios" class="botones_encabezado" runat="server" Text="Usuarios" />
                <asp:Button ID="btn_Clientes" class="botones_encabezado" runat="server" Text="Clientes" />
                <asp:Button ID="btn_Marcas" class="botones_encabezado" runat="server" Text="Marcas" />
                <asp:Button ID="Button6" class="botones_encabezado" runat="server" Text="Categorias" />
                <asp:Button ID="btn_Productos" class="botones_encabezado" runat="server" Text="Articulos" />
                <asp:Button ID="btn_Facturacion" class="botones_encabezado" runat="server" Text="Facturacion" />                
                
                <asp:Button ID="btn_Reportes" class="botones_encabezado" runat="server" Text="Reportes" />
                <br />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="Label4" class="encabezado_secundario" runat="server" Text="Proyecto Programacion IV"></asp:Label>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            </div>
        </header>
        <div class="contenedor_principal-login">
            <div class="contenedor_login">
                <div>
                    <asp:Label ID="Label1" class="titulo_inicio-sesion" runat="server" Text="Inicio de sesión"></asp:Label>
                </div>
                <div class="formulario_login">
                    <div class="formulario_login-usuario">
                        <asp:Label ID="Label2" CssClass="etiquetas_formulario" runat="server" Text="Usuario"></asp:Label>
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:TextBox ID="txtUsuario" CssClass="textbox-form" runat="server"></asp:TextBox>
                    </div>
                    <div class="formulario_login-contraseña">
                        <asp:Label ID="Label5" CssClass="etiquetas_formulario" runat="server" Text="Contraseña"></asp:Label>
                        <asp:TextBox ID="txtContraseña" CssClass="textbox-form" runat="server"></asp:TextBox>
                    </div>
                    <asp:Button ID="btnIniciar" CssClass="boton_inicio" runat="server" Text="Iniciar sesión" OnClick="btnIniciar_Click" />
                </div>
            </div>
        </div>
    </form>
</body>
</html>
