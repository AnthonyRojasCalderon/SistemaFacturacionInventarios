using ObjetosNegocio;
using System;
using System.Web.UI.WebControls;

namespace WEBService
{
    public partial class Facturación : System.Web.UI.Page
    {
        ServiceReference1.ServiceClient proxy = new ServiceReference1.ServiceClient();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                cargarGridView();
                llenarDropClientes();
                txtidProducto.Visible = false;
            }
        }

        private void cargarGridView()
        {
            gvFacturas.DataSource = proxy.obtenerArticulos();
            gvFacturas.DataBind();
        }

        private void limpiar()
        {
            txtCantidad.Text = "";
            txtFecha.Text = "";
            txtPrecio.Text = "";
            txtTotal.Text = "";
            txtProducto.Text = "";
            txtSubtotal.Text = "";
        }

        private void llenarDropClientes()
        {
            dp_Clientes.DataSource = proxy.obtenerClientes();
            dp_Clientes.DataTextField = "nombre";
            dp_Clientes.DataValueField = "id";
            dp_Clientes.DataBind();
            dp_Clientes.Items.Insert(0, new ListItem("[Seleccionar]", "0"));
        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {

            try
            {
                if (txtFecha.Text != String.Empty
                    && txtCantidad.Text != String.Empty
                    && dp_Clientes.SelectedValue != String.Empty
                    && txtidProducto.Text != String.Empty
                    && txtTotal.Text != String.Empty
                    && txtPrecio.Text != String.Empty)
                {
                    FacturasNegocio factura = new FacturasNegocio
                    {
                        fecha = Convert.ToDateTime(txtFecha.Text),
                        cantidad = Convert.ToInt32(txtCantidad.Text),
                        clientes = new ClientesNegocio { id = Convert.ToInt32(dp_Clientes.SelectedValue) },
                        articulo = new ArticulosNegocio { id = Convert.ToInt32(txtidProducto.Text) },
                        total = Convert.ToInt32(txtTotal.Text)
                    };
                    proxy.agregarFactura(factura);
                    Response.Write("<script> alert(" + "'Factura agregada'" + ")</script>");
                }
                else
                {
                    Response.Write("<script> alert(" + "'Seleccione un producto y agregue la cantidad'" + ")</script>");
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
                llenarDropClientes();
            }
        }

        protected void gvFacturas_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridViewRow row = gvFacturas.SelectedRow;

            int idProducto = Convert.ToInt32(row.Cells[1].Text);
            string precioProducot = row.Cells[2].Text;
            string nombreProcucto = row.Cells[3].Text;

            txtProducto.Text = nombreProcucto;
            txtPrecio.Text = precioProducot;
            txtidProducto.Text = idProducto.ToString();
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
            Response.Redirect("~/Facturacion.aspx");
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

        protected void btnCancelarP_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        protected void btnagregarP_Click(object sender, EventArgs e)
        {
            if (txtCantidad.Text != String.Empty
                && txtPrecio.Text != String.Empty)
            {
                double subtotal = Convert.ToDouble(txtCantidad.Text) * Convert.ToDouble(txtPrecio.Text);
                txtSubtotal.Text = subtotal.ToString();

                double total = (subtotal * 0.13) + subtotal;
                txtTotal.Text = total.ToString();
            }
            else
            {
                Response.Write("<script> alert(" + "'Seleccione un producto y agregue la cantidad'" + ")</script>");
            }
        }

        protected void gvFacturas_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {

            try
            {
                int id = Int32.Parse(gvFacturas.Rows[e.RowIndex].Cells[0].Text);
                proxy.eliminarFactura(id);
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