using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WEBService
{
    public partial class Login : System.Web.UI.Page
    {
        ServiceReference1.ServiceClient proxy = new ServiceReference1.ServiceClient();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnIniciar_Click(object sender, EventArgs e)
        {
            try
            {
                var login = proxy.login(txtContraseña.Text,txtUsuario.Text);
                if (login == true)
                {
                    Response.Redirect("~/Usuarios.aspx");
                }
                else
                {
                    Response.Write("<script> alert(" + "'Usuario incorrecto'" + ")</script>");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}