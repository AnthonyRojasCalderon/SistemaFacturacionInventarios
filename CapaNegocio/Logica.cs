using ObjetosNegocio;
using System.Collections.Generic;
using System.Linq;
using CapaDatos;

namespace CapaNegocio
{
    public class Logica
    {
        private LQ_FacturacionDataContext db;
        private AccesoDatos datos;

        public Logica()
        {
            db = new LQ_FacturacionDataContext();
            datos = new AccesoDatos();
        }

        #region Usuarios

        public bool login(string usuario, string contraseña)
        {
            var consulta = datos.login(usuario,contraseña);
            return consulta;
        }

        public List<UsuariosNegocio> obtenerUsuarios()
        {
            var consulta = datos.obtenerUsuarios();
            return consulta;
        }

        public void agregarUsuario(UsuariosNegocio usuario)
        {
            datos.agregarUsuarios(usuario);
        }

        public void actualizarUsuario(UsuariosNegocio usuarios)
        {
            datos.actualizarUsuario(usuarios);
        }

        public void eliminarUsuario(int id)
        {
            datos.eliminarUsuario(id);
        }
        #endregion

        #region Clientes

        public List<ClientesNegocio> obtenerClientes()
        {
            var consulta = datos.obtenerClientes();
            return consulta;
        }

        public void agregarCliente(ClientesNegocio clientes)
        {
            datos.agregarCliente(clientes);
        }

        public void actualizarCliente(ClientesNegocio clientes)
        {
            datos.actualizarCliente(clientes);
        }

        public void eliminarCliente(int id)
        {
            datos.eliminarCliente(id);
        }

        #endregion

        #region Marcas

        public List<MarcasNegocio> obtenerMarca()
        {
            var consulta = datos.obtenerMarcas();

            return consulta;
        }

        public void agregarMarca(MarcasNegocio marca)
        {
            datos.agregarMarca(marca);
        }

        public void actualizarMarca(MarcasNegocio marca)
        {
            datos.actualizarMarca(marca);
        }

        public void eliminarMarca(int id)
        {
            datos.eliminarMarca(id);
        }

        #endregion

        #region Categorias

        public List<CategoriasNegocio> obtenerCategorias()
        {
            var consulta = datos.obtenerCategorias();

            return consulta;
        }

        public void agregarCategoria(CategoriasNegocio categoria)
        {
            datos.agregarCategoria(categoria);
        }

        public void actualizarCategoria(CategoriasNegocio categoria)
        {
            datos.actualizarCategoria(categoria);
        }

        public void eliminarCategoria(int id)
        {
            datos.eliminarCategoria(id);
        }

        #endregion

        #region Articulos

        public List<ArticulosNegocio> obtenerArticulos()
        {
            List<ArticulosNegocio> articulos = datos.obtenerArticulos();

            return articulos;
        }

        public void agregarArticulo(ArticulosNegocio articulo)
        {
            datos.agregarArticulo(articulo);
        }

        public void actualizarArticulo(ArticulosNegocio articulo)
        {
            datos.actualizarArticulo(articulo);
        }

        public void eliminarArticulo(int id)
        {
            datos.eliminarArticulo(id);
        }

        #endregion

        #region Factura

        public List<FacturasNegocio> obtenerFacturas()
        {

            List<FacturasNegocio> facturas = datos.obtenerFacturas();

            return facturas;
        }

        public void agregarFactura(FacturasNegocio factura)
        {

            datos.agregarFactura(factura);
        }


        public void eliminarFactura(int id)
        {

            datos.eliminarFactura(id);
        }

        #endregion

        #region DetalleFacturacion

        public List<DetalleFacturasNegocio> obtenerDetalleFacturas()
        {
            List<DetalleFacturasNegocio> detalleFacturas = datos.obtenerDetalleFacturas();
            return detalleFacturas;
        }

        #endregion
    }
}
