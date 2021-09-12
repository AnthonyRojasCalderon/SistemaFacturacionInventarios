using ObjetosNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WEBService
{
    public partial class Categorias : System.Web.UI.Page
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
            gvCategorias.DataSource = proxy.obtenerCategorias();
            gvCategorias.DataBind();
        }

        private void limpiar()
        {
            txtNombre.Text = "";
            txtDescripcion.Text = "";
        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                CategoriasNegocio categoria = new CategoriasNegocio();
                if (txtNombre.Text != String.Empty
                    && txtDescripcion.Text != String.Empty)
                    categoria.nombre = txtNombre.Text;
                categoria.descripcion = txtDescripcion.Text;
                proxy.agregarCategoria(categoria);
                Response.Write("<script> alert(" + "'Categoria agregada'" + ")</script>");
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

        protected void gvCategorias_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            gvCategorias.EditIndex = -1;
            cargarGridView();
        }

        protected void gvCategorias_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            try
            {
                int id = Int32.Parse(gvCategorias.Rows[e.RowIndex].Cells[0].Text);
                proxy.eliminarCategoria(id);
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

        protected void gvCategorias_RowEditing(object sender, GridViewEditEventArgs e)
        {
            gvCategorias.EditIndex = e.NewEditIndex;
            cargarGridView();
        }

        protected void gvCategorias_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            GridViewRow row = gvCategorias.Rows[e.RowIndex];

            int idCategoria = int.Parse(((TextBox)(row.Cells[0].Controls[0])).Text);
            string nombreCategoria = ((TextBox)(row.Cells[1].Controls[0])).Text;
            string descripcionCategoria = ((TextBox)(row.Cells[2].Controls[0])).Text;
            try
            {
                if (nombreCategoria != String.Empty
                    && descripcionCategoria != String.Empty)
                {
                    CategoriasNegocio categoria = new CategoriasNegocio
                    {
                        id = idCategoria,
                        nombre = nombreCategoria,
                        descripcion = descripcionCategoria
                    };
                    proxy.actualizarCategoria(categoria);
                }
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message.ToString());

            }
            finally
            {
                gvCategorias.EditIndex = -1;
                cargarGridView();
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

        protected void Button6_Click(object sender, EventArgs e)
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