namespace ObjetosNegocio
{
    public class ArticulosNegocio
    {
        public int id { get; set; }

        public decimal precio { get; set; }

        public string descripcion { get; set; }

        public string nombre { get; set; }

        public MarcasNegocio marca { get; set; } 

        public CategoriasNegocio categoria { get; set; }
    }
}
