using System;

namespace ObjetosNegocio
{
    public class FacturasNegocio
    {
        public int id { get; set; }

        public DateTime fecha { get; set; }

        public int cantidad { get; set; }

        public ClientesNegocio clientes { get; set; }

        public ArticulosNegocio articulo { get; set; }

        public decimal total { get; set; }
    }
}
