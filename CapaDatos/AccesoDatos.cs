using System.Collections.Generic;
using System.Linq;
using ObjetosNegocio;

namespace CapaDatos
{
    public class AccesoDatos
    {
        private LQ_FacturacionDataContext db;

        public AccesoDatos()
        {
            db = new LQ_FacturacionDataContext();
        }

        #region Articulos
        public List<ArticulosNegocio> obtenerArticulos()
        {
            var consulta = db.Articulos.ToList();
            List<ArticulosNegocio> articulos = consulta.Select(x => new ArticulosNegocio
            {
                id = x.idArticulo,
                nombre = x.producto,
                descripcion = x.descripcion,
                precio = x.precioUnitario,
                marca = new MarcasNegocio { id = x.Marca.idMarca, nombre = x.Marca.nombre, descripcion = x.Marca.descripcion },
                categoria = new CategoriasNegocio { id = x.Categoria.idCategoria, nombre = x.Categoria.nombre, descripcion = x.Categoria.descripcion }

            }).ToList();

            return articulos;
        }

        public void agregarArticulo(ArticulosNegocio articulo)
        {
            Articulo articulodb = new Articulo
            {
                precioUnitario = articulo.precio,
                descripcion = articulo.descripcion,
                producto = articulo.nombre,
                idMarca = articulo.marca.id,
                idCategoria = articulo.categoria.id
            };
            db.Articulos.InsertOnSubmit(articulodb);
            db.SubmitChanges();
        }

        public void actualizarArticulo(ArticulosNegocio articulo)
        {
            Articulo articulodb = db.Articulos.Where(x => x.idArticulo == articulo.id).FirstOrDefault();
            articulodb.precioUnitario = articulo.precio;
            articulodb.descripcion = articulo.descripcion;
            articulodb.producto = articulo.nombre;
            articulodb.idMarca = articulo.marca.id;
            articulodb.idCategoria = articulo.categoria.id;

            db.SubmitChanges();
        }

        public void eliminarArticulo(int id)
        {
            var consulta = (from a in db.Articulos
                            where a.idArticulo == id
                            select a).First();
            db.Articulos.DeleteOnSubmit(consulta);
            db.SubmitChanges();
        }

        #endregion

        #region Marcas
        public List<MarcasNegocio> obtenerMarcas()
        {
            var consulta = db.Marcas.ToList();
            List<MarcasNegocio> marcas = consulta.Select(x => new MarcasNegocio
            {
                id = x.idMarca,
                nombre = x.nombre,
                descripcion = x.descripcion
            }).ToList();

            return marcas;
        }

        public void agregarMarca(MarcasNegocio marca)
        {
            Marca marcadb = new Marca { idMarca = marca.id, nombre = marca.nombre, descripcion = marca.descripcion };
            db.Marcas.InsertOnSubmit(marcadb);
            db.SubmitChanges();
        }

        public void eliminarMarca(int id)
        {
            var consulta = (from m in db.Marcas
                            where m.idMarca == id
                            select m).First();
            db.Marcas.DeleteOnSubmit(consulta);
            db.SubmitChanges();
        }

        public void actualizarMarca(MarcasNegocio marca)
        {
            Marca marcadb = db.Marcas.Where(x => x.idMarca == marca.id).FirstOrDefault();
            marcadb.nombre = marca.nombre;
            marcadb.descripcion = marca.descripcion;
            db.SubmitChanges();
        }

        #endregion

        #region Categorias

        public List<CategoriasNegocio> obtenerCategorias()
        {
            var consulta = db.Categorias.ToList();
            List<CategoriasNegocio> categorias = consulta.Select(x => new CategoriasNegocio
            {
                id = x.idCategoria,
                nombre = x.nombre,
                descripcion = x.descripcion

            }).ToList();

            return categorias;
        }

        public void agregarCategoria(CategoriasNegocio categoria)
        {
            Categoria categoriadb = new Categoria { idCategoria = categoria.id, nombre = categoria.nombre, descripcion = categoria.descripcion };
            db.Categorias.InsertOnSubmit(categoriadb);
            db.SubmitChanges();
        }

        public void actualizarCategoria(CategoriasNegocio categoria)
        {
            Categoria categoriadb = db.Categorias.Where(x => x.idCategoria == categoria.id).FirstOrDefault();
            categoriadb.nombre = categoria.nombre;
            categoriadb.descripcion = categoria.descripcion;
            db.SubmitChanges();
        }

        public void eliminarCategoria(int id)
        {
            var consulta = (from c in db.Categorias
                            where c.idCategoria == id
                            select c).First();
            db.Categorias.DeleteOnSubmit(consulta);
            db.SubmitChanges();
        }

        #endregion

        #region Clientes

        public List<ClientesNegocio> obtenerClientes()
        {
            var consulta = db.Clientes.ToList();
            List<ClientesNegocio> clientes = consulta.Select(x => new ClientesNegocio
            {
                id = x.idCliente,
                cedula = x.cedula,
                nombre = x.nombre,
                apellidos = x.apellidos,
                telefono = x.telefono,
                correo = x.correo
            }).ToList();

            return clientes;
        }

        public void agregarCliente(ClientesNegocio clientes)
        {
            Cliente clientedb = new Cliente { idCliente = clientes.id, cedula = clientes.cedula, nombre = clientes.nombre, apellidos = clientes.apellidos, telefono = clientes.telefono, correo = clientes.correo };
            db.Clientes.InsertOnSubmit(clientedb);
            db.SubmitChanges();
        }

        public void actualizarCliente(ClientesNegocio clientes)
        {
            Cliente clientedb = db.Clientes.Where(x => x.idCliente == clientes.id).FirstOrDefault();
            clientedb.cedula = clientes.cedula;
            clientedb.nombre = clientes.nombre;
            clientedb.apellidos = clientes.apellidos;
            clientedb.telefono = clientes.telefono;
            clientedb.correo = clientes.correo;
            db.SubmitChanges();
        }

        public void eliminarCliente(int id)
        {
            var consulta = (from c in db.Clientes
                            where c.idCliente == id
                            select c).First();
            db.Clientes.DeleteOnSubmit(consulta);
            db.SubmitChanges();
        }

        #endregion

        #region Usuarios

        public bool login(string usuario, string contraseña)
        {
            int validar = (from p in db.Usuarios
                           where (p.usuario == usuario && (p.contraseña == contraseña))
                           select p).Count();

            return validar == 0 ? false : true;
        }

        public List<UsuariosNegocio> obtenerUsuarios()
        {
            var consulta = db.Usuarios.ToList();
            List<UsuariosNegocio> usuarios = consulta.Select(x => new UsuariosNegocio
            {
                id = x.idUsuario,
                cedula = x.cedula,
                nombre = x.nombre,
                apellidos = x.apellidos,
                correo = x.correo,
                contraseña = x.contraseña,
                usuario = x.usuario,
            }).ToList();

            return usuarios;
        }

        public void agregarUsuarios(UsuariosNegocio usuarios)
        {
            Usuario usuariodb = new Usuario
            {
                idUsuario = usuarios.id,
                cedula = usuarios.cedula,
                nombre = usuarios.nombre,
                apellidos = usuarios.apellidos,
                correo = usuarios.correo,
                contraseña = usuarios.contraseña,
                usuario = usuarios.usuario
            };

            db.Usuarios.InsertOnSubmit(usuariodb);
            db.SubmitChanges();
        }

        public void actualizarUsuario(UsuariosNegocio usuarios)
        {
            Usuario usuariodb = db.Usuarios.Where(x => x.idUsuario == usuarios.id).FirstOrDefault();
            usuariodb.cedula = usuarios.cedula;
            usuariodb.nombre = usuarios.nombre;
            usuariodb.apellidos = usuarios.apellidos;
            usuariodb.correo = usuariodb.correo;
            usuariodb.contraseña = usuarios.contraseña;
            usuariodb.usuario = usuarios.usuario;
            db.SubmitChanges();
        }

        public void eliminarUsuario(int id)
        {
            var consulta = (from u in db.Usuarios
                            where u.idUsuario == id
                            select u).First();
            db.Usuarios.DeleteOnSubmit(consulta);
            db.SubmitChanges();
        }

        #endregion

        #region Factura

        public List<FacturasNegocio> obtenerFacturas()
        {
            var consulta = db.Facturas.ToList();
            List<FacturasNegocio> facturas = consulta.Select(x => new FacturasNegocio
            {
                id = x.idArticulo,
                fecha = x.fecha,
                cantidad = x.cantidad,
                clientes = new ClientesNegocio
                {
                    id = x.Cliente.idCliente,
                    cedula = x.Cliente.cedula,
                    nombre = x.Cliente.nombre,
                    apellidos = x.Cliente.apellidos,
                    telefono = x.Cliente.telefono
                },
                articulo = new ArticulosNegocio
                {
                    id = x.Articulo.idArticulo,
                    precio = x.Articulo.precioUnitario,
                    descripcion = x.Articulo.descripcion,
                    nombre = x.Articulo.producto
                },
                total = x.total

            }).ToList();

            return facturas;
        }

        public void agregarFactura(FacturasNegocio factura)
        {
            Factura facturadb = new Factura
            {
                fecha = factura.fecha,
                cantidad = factura.cantidad,
                idCliente = factura.clientes.id,
                idArticulo = factura.articulo.id,
                total = factura.total
            };
            db.Facturas.InsertOnSubmit(facturadb);
            db.SubmitChanges();
        }

        public void eliminarFactura(int id)
        {
            var consulta = (from f in db.Facturas
                            where f.idFactura == id
                            select f).First();
            db.Facturas.DeleteOnSubmit(consulta);
            db.SubmitChanges();
        }

        #endregion

        #region DetalleFacturas

        public List<DetalleFacturasNegocio> obtenerDetalleFacturas()
        {
            var consulta = (from f in db.Facturas
                            join al in db.Articulos on f.idArticulo equals al.idArticulo
                            join cl in db.Clientes on f.idCliente equals cl.idCliente
                            select new DetalleFacturasNegocio
                            {
                                nombreCliente = cl.nombre,
                                nombreArticulo = al.producto,
                                marca = al.Marca.nombre,
                                categoria = al.Categoria.nombre,
                                cantidad = f.cantidad,
                                total = f.total

                            }).ToList();

            return consulta;
        }

        #endregion
    }
}
