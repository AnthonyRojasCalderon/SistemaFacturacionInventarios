using ObjetosNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WEBService
{
    public partial class Clientes : System.Web.UI.Page
    {
        ServiceReference1.ServiceClient proxy = new ServiceReference1.ServiceClient();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                cargarGridView();
            }
        }

        private void cargarGridView()
        {
            gvClientes.DataSource = proxy.obtenerClientes();
            gvClientes.DataBind();
        }

        private void limpiar()
        {
            txtCedula.Text = "";
            txtNombre.Text = "";
            txtCorreo.Text = "";
            txtApellidos.Text = "";
            txtTelefono.Text = "";
        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtCedula.Text != String.Empty
                    && txtNombre.Text != String.Empty
                    && txtApellidos.Text != String.Empty
                    && txtCorreo.Text != String.Empty
                    && txtTelefono.Text != String.Empty)
                {
                    ClientesNegocio clientes = new ClientesNegocio
                    {
                        cedula = txtCedula.Text,
                        nombre = txtNombre.Text,
                        apellidos = txtApellidos.Text,
                        correo = txtCorreo.Text,
                        telefono = txtTelefono.Text
                    };
                    proxy.agregarCliente(clientes);
                    Response.Write("<script> alert(" + "'Cliente agregado'" + ")</script>");
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
                limpiar();
                cargarGridView();
            }
        }

        protected void gvClientes_RowEditing(object sender, GridViewEditEventArgs e)
        {
            gvClientes.EditIndex = e.NewEditIndex;
            cargarGridView();
            ocultar.Visible = false;
        }

        protected void gvClientes_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            try
            {
                int id = Int32.Parse(gvClientes.Rows[e.RowIndex].Cells[0].Text);
                proxy.eliminarCliente(id);
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message.ToString());
            }
            finally
            {
                cargarGridView();
            }
        }

        protected void gvClientes_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            gvClientes.EditIndex = -1;
            cargarGridView();
            ocultar.Visible = false;
        }

        protected void gvClientes_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            GridViewRow row = gvClientes.Rows[e.RowIndex];
            int idCliente = int.Parse(((TextBox)(row.Cells[0].Controls[0])).Text);
            string cedulaCliente = ((TextBox)(row.Cells[1].Controls[0])).Text;
            string nombreCliente = ((TextBox)(row.Cells[2].Controls[0])).Text;
            string apellidosCliente = ((TextBox)(row.Cells[3].Controls[0])).Text;
            string telefonoCliente = ((TextBox)(row.Cells[4].Controls[0])).Text;
            string correoCliente = ((TextBox)(row.Cells[5].Controls[0])).Text;
            try
            {
                if (cedulaCliente != String.Empty && nombreCliente != String.Empty
                    && apellidosCliente != String.Empty && telefonoCliente != String.Empty
                    && correoCliente != String.Empty)
                {
                    ClientesNegocio clientes = new ClientesNegocio
                    {
                        id = idCliente,
                        cedula = cedulaCliente,
                        nombre = nombreCliente,
                        apellidos = apellidosCliente,
                        telefono = telefonoCliente,
                        correo = correoCliente
                    };
                    proxy.actualizarCliente(clientes);
                    Response.Write("<script> alert(" + "'Cliente actualizado'" + ")</script>");
                }
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message.ToString());

            }
            finally
            {
                gvClientes.EditIndex = -1;
                cargarGridView();
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

        protected void btn_Facturacion_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Facturación.aspx");
        }
    }
}