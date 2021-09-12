using ObjetosNegocio;
using System;
using System.Web.UI.WebControls;

namespace WEBService
{
    public partial class Articulos : System.Web.UI.Page
    {
        ServiceReference1.ServiceClient proxy = new ServiceReference1.ServiceClient();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                cargarGridView();
                llenarDropCategorias();
                llenarDropMarcas();
            }
        }

        private void cargarGridView()
        {
            gvArticulos.DataSource = proxy.obtenerArticulos();
            gvArticulos.DataBind();
        }

        private void limpiar()
        {
            txtPrecio.Text = "";
            txtNombre.Text = "";
            txtDescripcion.Text = "";
        }

        private void llenarDropCategorias()
        {
            dp_Categorias.DataSource = proxy.obtenerCategorias();
            dp_Categorias.DataTextField = "nombre";
            dp_Categorias.DataValueField = "id";
            dp_Categorias.DataBind();
            dp_Categorias.Items.Insert(0, new ListItem("[Seleccionar]", "0"));
        }

        private void llenarDropMarcas()
        {
            dp_Marcas.DataSource = proxy.obtenerMarca();
            dp_Marcas.DataTextField = "nombre";
            dp_Marcas.DataValueField = "id";
            dp_Marcas.DataBind();
            dp_Marcas.Items.Insert(0, new ListItem("[Seleccionar]", "0"));
        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtPrecio.Text != String.Empty
                    && txtDescripcion.Text != String.Empty
                    && txtNombre.Text != String.Empty
                    && dp_Marcas.SelectedValue != String.Empty
                    && dp_Categorias.SelectedValue != String.Empty)
                {
                    ArticulosNegocio articulo = new ArticulosNegocio
                    {
                        precio = Convert.ToDecimal(txtPrecio.Text),
                        nombre = txtNombre.Text,
                        descripcion = txtDescripcion.Text,
                        marca = new MarcasNegocio { id = Convert.ToInt32(dp_Marcas.SelectedValue) },
                        categoria = new CategoriasNegocio { id = Convert.ToInt32(dp_Categorias.SelectedValue) }
                    };
                    proxy.agregarArticulo(articulo);
                    Response.Write("<script> alert(" + "'Articulo agregado'" + ")</script>");
                }
            }
            catch (LinqDataSourceValidationException ex)
            {
                Response.Write(ex.Message.ToString());
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message.ToString() + "<script> alert(" + "'Ingrese un precio valido'" + ")</script>");
            }
            finally
            {
                limpiar();
                cargarGridView();
                llenarDropCategorias();
                llenarDropMarcas();
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

        protected void gvArticulos_RowEditing(object sender, GridViewEditEventArgs e)
        {
            gvArticulos.EditIndex = e.NewEditIndex;
            cargarGridView();
            ocultar.Visible = false;
            DropDownList comboMarcas = gvArticulos.Rows[e.NewEditIndex].FindControl("dp_comboM") as DropDownList;
            if (comboMarcas != null)
            {
                comboMarcas.DataSource = proxy.obtenerMarca();
                comboMarcas.DataTextField = "nombre";
                comboMarcas.DataValueField = "id";
                comboMarcas.DataBind();
            }

            DropDownList comboCategorias = gvArticulos.Rows[e.NewEditIndex].FindControl("dp_comboC") as DropDownList;
            if (comboMarcas != null)
            {
                comboCategorias.DataSource = proxy.obtenerCategorias();
                comboCategorias.DataTextField = "nombre";
                comboCategorias.DataValueField = "id";
                comboCategorias.DataBind();
            }
        }

        protected void gvArticulos_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            gvArticulos.EditIndex = -1;
            cargarGridView();
        }

        protected void gvArticulos_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            GridViewRow row = gvArticulos.Rows[e.RowIndex];
            int idArticulo = int.Parse(((TextBox)(row.Cells[0].Controls[0])).Text);
            string precioArticulo = ((TextBox)(row.Cells[2].Controls[0])).Text;
            string descripcionArticulo = ((TextBox)(row.Cells[3].Controls[0])).Text;
            string nombreArticulo = ((TextBox)(row.Cells[1].Controls[0])).Text;
            DropDownList comboMarca = gvArticulos.Rows[e.RowIndex].FindControl("dp_comboM") as DropDownList;
            int idMarca = Convert.ToInt32(comboMarca.SelectedValue);
            DropDownList comboCategorias = gvArticulos.Rows[e.RowIndex].FindControl("dp_comboC") as DropDownList;
            int idCategoria = Convert.ToInt32(comboCategorias.SelectedValue);
            try
            {
                if (precioArticulo != String.Empty && descripcionArticulo != String.Empty
                    && nombreArticulo != String.Empty && comboMarca.SelectedValue != String.Empty
                    && comboCategorias.SelectedValue != String.Empty)
                {
                    ArticulosNegocio articulo = new ArticulosNegocio
                    {
                        id = idArticulo,
                        precio = Convert.ToDecimal(precioArticulo),
                        descripcion = descripcionArticulo,
                        nombre = nombreArticulo,
                        marca = new MarcasNegocio { id = Convert.ToInt32(comboMarca.SelectedValue) },
                        categoria = new CategoriasNegocio { id = Convert.ToInt32(comboCategorias.SelectedValue) }
                    };
                    proxy.actualizarArticulo(articulo);
                    Response.Write("<script> alert(" + "'Articulo actualizado'" + ")</script>");
                }
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message.ToString());

            }
            finally
            {
                gvArticulos.EditIndex = -1;
                cargarGridView();
                ocultar.Visible = true;
            }
        }

        protected void gvArticulos_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {

            try
            {
                int id = Int32.Parse(gvArticulos.Rows[e.RowIndex].Cells[0].Text);
                proxy.eliminarArticulo(id);
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
    }
}