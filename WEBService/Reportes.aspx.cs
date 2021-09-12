using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WEBService
{
    public partial class Reportes : System.Web.UI.Page
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
            gvDetalle.DataSource = proxy.obtenerDetalleFacturas();
            gvDetalle.DataBind();
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

        protected void Button6_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Categorias.aspx");
        }

        protected void btn_Reportes_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Reportes.aspx");
        }
    }
}