using CrudApi.Interfaces;
using CrudApi.Models;

namespace CrudApi.Services
{
    public class ProductoService : IProductoService
    {
        private readonly List<Producto> _productos = new()
        {
            new Producto { Id = 1, Nombre = "Laptop", Precio = 500 },
            new Producto { Id = 2, Nombre = "Mouse", Precio = 20 }
        };

        public List<Producto> GetAll()
        {
            return _productos;
        }

        public Producto? GetById(int id)
        {
            return _productos.FirstOrDefault(p => p.Id == id);
        }

        public Producto Add(Producto producto)
        {
            producto.Id = _productos.Count + 1;
            _productos.Add(producto);
            return producto;
        }

        public Producto Update(int id, Producto producto)
        {
            var existente = _productos.FirstOrDefault(p => p.Id == id);

            if (existente == null)
                throw new Exception("Producto no encontrado");

            existente.Nombre = producto.Nombre;
            existente.Precio = producto.Precio;

            return existente;
        }

        public bool Delete(int id)
        {
            var producto = _productos.FirstOrDefault(p => p.Id == id);

            if (producto == null)
                return false;

            _productos.Remove(producto);
            return true;
        }
    }
}