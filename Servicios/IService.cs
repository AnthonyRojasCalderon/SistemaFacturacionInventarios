using ObjetosNegocio;
using System.Collections.Generic;
using System.ServiceModel;

namespace Servicios
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService" in both code and config file together.
    [ServiceContract]
    public interface IService
    {
        #region Usuarios

        [OperationContract]
        bool login(string usuario, string contraseña);

        [OperationContract]
        List<UsuariosNegocio> obtenerUsuarios();

        [OperationContract]
        void agregarUsuario(UsuariosNegocio usuarios);

        [OperationContract]
        void actualizarUsuario(UsuariosNegocio usuarios);

        [OperationContract]
        void eliminarUsuario(int id);

        #endregion

        #region Clientes

        [OperationContract]
        List<ClientesNegocio> obtenerClientes();

        [OperationContract]
        void agregarCliente(ClientesNegocio clientes);

        [OperationContract]
        void actualizarCliente(ClientesNegocio clientes);

        [OperationContract]
        void eliminarCliente(int id);

        #endregion

        #region Marcas

        [OperationContract]
        List<MarcasNegocio> obtenerMarca();

        [OperationContract]
        void agregarMarca(MarcasNegocio marca);

        [OperationContract]
        void actualizarMarca(MarcasNegocio marca);

        [OperationContract]
        void eliminarMarca(int id);


        #endregion

        #region Categorias

        [OperationContract]
        List<CategoriasNegocio> obtenerCategorias();

        [OperationContract]
        void agregarCategoria(CategoriasNegocio categoria);

        [OperationContract]
        void actualizarCategoria(CategoriasNegocio categoria);

        [OperationContract]
        void eliminarCategoria(int id);

        #endregion

        #region Articulos

        [OperationContract]
        List<ArticulosNegocio> obtenerArticulos();

        [OperationContract]
        void agregarArticulo(ArticulosNegocio articulo);

        [OperationContract]
        void actualizarArticulo(ArticulosNegocio articulo);

        [OperationContract]
        void eliminarArticulo(int id);

        #endregion

        #region Factura

        [OperationContract]
        List<FacturasNegocio> obtenerFacturas();
        
        [OperationContract]
        void agregarFactura(FacturasNegocio factura);

        [OperationContract]
        void eliminarFactura(int id);

        #endregion

        #region DetalleFacturas

        [OperationContract]
        List<DetalleFacturasNegocio> obtenerDetalleFacturas();

        #endregion
    }
}
