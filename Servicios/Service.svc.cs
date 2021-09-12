using ObjetosNegocio;
using CapaNegocio;
using System.Collections.Generic;

namespace Servicios
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service.svc or Service.svc.cs at the Solution Explorer and start debugging.
    public class Service : IService
    {
        private Logica logica;

        public Service()
        {
            logica = new Logica();
        }

        #region Usuarios
        public bool login(string usuario, string contraseña)
        {
            return logica.login(usuario, contraseña);
        }

        public List<UsuariosNegocio> obtenerUsuarios()
        {
            return logica.obtenerUsuarios();
        }

        public void agregarUsuario(UsuariosNegocio usuarios)
        {
            logica.agregarUsuario(usuarios);
        }

        public void actualizarUsuario(UsuariosNegocio usuarios)
        {
            logica.actualizarUsuario(usuarios);
        }

        public void eliminarUsuario(int id)
        {
            logica.eliminarUsuario(id);
        }

        #endregion

        #region Clientes
        public List<ClientesNegocio> obtenerClientes()
        {
            return logica.obtenerClientes();
        }

        public void agregarCliente(ClientesNegocio clientes)
        {
            logica.agregarCliente(clientes);
        }

        public void actualizarCliente(ClientesNegocio clientes)
        {
            logica.actualizarCliente(clientes);
        }

        public void eliminarCliente(int id)
        {
            logica.eliminarCliente(id);
        }
        #endregion

        #region Marcas

        public List<MarcasNegocio> obtenerMarca()
        {
            return logica.obtenerMarca();
        }

        public void agregarMarca(MarcasNegocio marca)
        {
            logica.agregarMarca(marca);
        }

        public void actualizarMarca(MarcasNegocio marca)
        {
            logica.actualizarMarca(marca);
        }

        public void eliminarMarca(int id)
        {
            logica.eliminarMarca(id);
        }

        #endregion

        #region Categorias

        public List<CategoriasNegocio> obtenerCategorias()
        {
            return logica.obtenerCategorias();
        }

        public void agregarCategoria(CategoriasNegocio categoria)
        {
            logica.agregarCategoria(categoria);
        }

        public void actualizarCategoria(CategoriasNegocio categoria)
        {
            logica.actualizarCategoria(categoria);
        }

        public void eliminarCategoria(int codigo)
        {
            logica.eliminarCategoria(codigo);
        }

        #endregion

        #region Articulos

        public List<ArticulosNegocio> obtenerArticulos()
        {
            return logica.obtenerArticulos();
        }

        public void agregarArticulo(ArticulosNegocio articulo)
        {
            logica.agregarArticulo(articulo);
        }

        public void actualizarArticulo(ArticulosNegocio articulo)
        {
            logica.actualizarArticulo(articulo);
        }

        public void eliminarArticulo(int id)
        {
            logica.eliminarArticulo(id);
        }

        #endregion

        #region Factura

        public List<FacturasNegocio> obtenerFacturas()
        {
            return logica.obtenerFacturas();
        }

        public void agregarFactura(FacturasNegocio factura)
        {
            logica.agregarFactura(factura);
        }

        public void eliminarFactura(int id)
        {
            logica.eliminarFactura(id);
        }

        #endregion

        #region DetalleFacturas

        public List<DetalleFacturasNegocio> obtenerDetalleFacturas()
        {
            return logica.obtenerDetalleFacturas();
        }

        #endregion
    }
}
