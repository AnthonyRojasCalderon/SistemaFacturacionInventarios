using ObjetosNegocio;
using System;
using System.Web.UI.WebControls;

namespace WEBService
{
    public partial class Marcas : System.Web.UI.Page
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
            gvMarcas.DataSource = proxy.obtenerMarca();
            gvMarcas.DataBind();
        }

        private void limpiar()
        {
            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtDescripcion.Text = "";
        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                MarcasNegocio marca = new MarcasNegocio();
                if (txtNombre.Text != String.Empty
                    && txtDescripcion.Text != String.Empty)
                    marca.nombre = txtNombre.Text;
                marca.descripcion = txtDescripcion.Text;
                proxy.agregarMarca(marca);
                Response.Write("<script> alert(" + "'Marca agregada'" + ")</script>");
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

        protected void gvMarcas_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            try
            {
                int id = Int32.Parse(gvMarcas.Rows[e.RowIndex].Cells[0].Text);
                proxy.eliminarMarca(id);
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

        protected void gvMarcas_RowEditing(object sender, GridViewEditEventArgs e)
        {
            gvMarcas.EditIndex = e.NewEditIndex;
            cargarGridView();
        }

        protected void gvMarcas_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            GridViewRow row = gvMarcas.Rows[e.RowIndex];
            int idMarca = int.Parse(((TextBox)(row.Cells[0].Controls[0])).Text);
            string nombreMarca = ((TextBox)(row.Cells[1].Controls[0])).Text;
            string descripcionMarca = ((TextBox)(row.Cells[2].Controls[0])).Text;
            try
            {
                if (nombreMarca != String.Empty
                    && descripcionMarca != String.Empty)
                {
                    MarcasNegocio marca = new MarcasNegocio { id = idMarca, nombre = nombreMarca, descripcion = descripcionMarca };
                    proxy.actualizarMarca(marca);
                }

            }
            catch (Exception ex)
            {
                Response.Write(ex.Message.ToString());

            }
            finally
            {
                gvMarcas.EditIndex = -1;
                cargarGridView();
            }
        }

        protected void gvMarcas_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            gvMarcas.EditIndex = -1;
            cargarGridView();
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