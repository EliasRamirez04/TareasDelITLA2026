using CrudApi.Models;

namespace CrudApi.Interfaces
{
    public interface IProductoService
    {
        List<Producto> GetAll();
        Producto? GetById(int id);
        Producto Add(Producto producto);
        Producto Update(int id, Producto producto);
        bool Delete(int id);
    }
}