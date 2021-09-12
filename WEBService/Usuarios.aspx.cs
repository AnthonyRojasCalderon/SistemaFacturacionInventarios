using ObjetosNegocio;
using System;
using System.Web.UI.WebControls;

namespace WEBService
{
    public partial class Usuarios : System.Web.UI.Page
    {
        ServiceReference1.ServiceClient proxy = new ServiceReference1.ServiceClient();

        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                cargarDataGrid();
            }
        }

        private void cargarDataGrid()
        {
            gvUsuarios.DataSource = proxy.obtenerUsuarios();
            gvUsuarios.DataBind();
        }

        private void limpiar()
        {
            txtNombre.Text = "";
            txtUsuario.Text = "";
            txtCorreo.Text = "";
            txtApellidos.Text = "";
            txtContraseña.Text = "";
            txtCedula.Text = "";
        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {

                if (txtCedula.Text != String.Empty
                    && txtNombre.Text != String.Empty
                    && txtApellidos.Text != String.Empty
                    && txtCorreo.Text != String.Empty
                    && txtContraseña.Text != String.Empty
                    && txtUsuario.Text != String.Empty)
                {
                    UsuariosNegocio usuario = new UsuariosNegocio
                    {
                        cedula = txtCedula.Text,
                        nombre = txtNombre.Text,
                        apellidos = txtApellidos.Text,
                        correo = txtCorreo.Text,
                        contraseña = txtContraseña.Text,
                        usuario = txtUsuario.Text
                    };
                    proxy.agregarUsuario(usuario);
                    Response.Write("<script> alert(" + "'Usuario agregado'" + ")</script>");
                }
            }
            catch (LinqDataSourceValidationException ex)
            {
                Response.Write(ex.Message.ToString());
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message.ToString());
            }
            finally
            {
                cargarDataGrid();
                limpiar();
            }
        }

        protected void gvUsuarios_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            gvUsuarios.EditIndex = -1;
            cargarDataGrid();
            ocultar.Visible = true;
        }

        protected void gvUsuarios_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            try
            {
                int id = Int32.Parse(gvUsuarios.Rows[e.RowIndex].Cells[0].Text);
                proxy.eliminarUsuario(id);
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message.ToString());
            }
            finally
            {
                cargarDataGrid();
            }
        }

        protected void gvUsuarios_RowEditing(object sender, GridViewEditEventArgs e)
        {
            gvUsuarios.EditIndex = e.NewEditIndex;
            cargarDataGrid();
            ocultar.Visible = false;
        }

        protected void gvUsuarios_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            GridViewRow row = gvUsuarios.Rows[e.RowIndex];
            int idUsuario = int.Parse(((TextBox)(row.Cells[0].Controls[0])).Text);
            string nombreUsuario = ((TextBox)(row.Cells[1].Controls[0])).Text;
            string cedulaUsuario = ((TextBox)(row.Cells[2].Controls[0])).Text;
            string nombre = ((TextBox)(row.Cells[3].Controls[0])).Text;
            string apellidosUsuario = ((TextBox)(row.Cells[4].Controls[0])).Text;
            string correoUsuario = ((TextBox)(row.Cells[5].Controls[0])).Text;
            string contraseñaUsuario = ((TextBox)(row.Cells[6].Controls[0])).Text;
            try
            {
                if (cedulaUsuario != String.Empty && nombre != String.Empty
                    && apellidosUsuario != String.Empty && correoUsuario != String.Empty
                    && nombre != String.Empty && contraseñaUsuario != String.Empty)
                {
                    UsuariosNegocio usuarios = new UsuariosNegocio
                    {
                        id = idUsuario,
                        nombre = nombre,
                        cedula = cedulaUsuario,
                        usuario = nombreUsuario,
                        apellidos = apellidosUsuario,
                        correo = correoUsuario,
                        contraseña = contraseñaUsuario
                    };
                    proxy.actualizarUsuario(usuarios);
                    Response.Write("<script> alert(" + "'Usuario actualizado'" + ")</script>");
                }

            }
            catch (Exception ex)
            {
                Response.Write(ex.Message.ToString());
            }
            finally
            {
                gvUsuarios.EditIndex = -1;
                cargarDataGrid();
                ocultar.Visible = true;
            }
        }

        protected void btn_Usuarios_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Usuarios.aspx");
        }

        protected void btn_Clientes_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Clientes.aspx");
        }

        protected void btn_Facturacion_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Facturación.aspx");
        }

        protected void btn_Productos_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Articulos.aspx");
        }

        protected void btn_Marcas_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Marcas.aspx");
        }

        protected void btn_Categorias_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Categorias.aspx");
        }

        protected void btn_Reportes_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Reportes.aspx");
        }
    }
}