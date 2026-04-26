using Microsoft.AspNetCore.Mvc;
using CrudApi.Interfaces;
using CrudApi.Models;

namespace CrudApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductoController : ControllerBase
    {
        private readonly IProductoService _service;

        public ProductoController(IProductoService service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_service.GetAll());
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var producto = _service.GetById(id);
            if (producto == null) return NotFound();
            return Ok(producto);
        }

        [HttpPost]
        public IActionResult Create(Producto producto)
        {
            var nuevo = _service.Add(producto);
            return Ok(nuevo);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, Producto producto)
        {
            return Ok(_service.Update(id, producto));
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return Ok(_service.Delete(id));
        }
    }
}