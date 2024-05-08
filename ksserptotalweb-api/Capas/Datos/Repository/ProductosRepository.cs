using System.Linq;

namespace ksserptotalweb_api.Capas.Datos.Repository
{
    public interface IProductoRepository
    {
        IQueryable<Productos> GetProductos();
        Productos GetProductos_idProducto(int idProducto);
    }
    public class ProductosRepository : IProductoRepository
    {
        private kss_dbEntities context;

        public ProductosRepository(kss_dbEntities context)
        {
            this.context = context;
        }

        public IQueryable<Productos> GetProductos()
        {
            return context.Productos;
        }

        public Productos GetProductos_idProducto(int idProducto)
        {
            return context.Productos.Where(a => a.id_Productos == idProducto).FirstOrDefault();
        }
    }
}
