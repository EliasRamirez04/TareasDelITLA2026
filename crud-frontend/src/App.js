import { useEffect, useState } from "react";

function App() {
  const [productos, setProductos] = useState([]);
  const [nombre, setNombre] = useState("");
  const [precio, setPrecio] = useState("");

  const url = "http://localhost:5067/api/producto";

  // Obtener productos
  const getProductos = async () => {
    const res = await fetch(url);
    const data = await res.json();
    setProductos(data);
  };

  useEffect(() => {
    getProductos();
  }, []);

  // Crear producto
  const crearProducto = async () => {
    await fetch(url, {
      method: "POST",
      headers: {
        "Content-Type": "application/json"
      },
      body: JSON.stringify({
        nombre,
        precio: parseFloat(precio)
      })
    });

    getProductos();
    setNombre("");
    setPrecio("");
  };

  // Eliminar producto
  const eliminarProducto = async (id) => {
    await fetch(`${url}/${id}`, {
      method: "DELETE"
    });

    getProductos();
  };

  return (
    <div style={{ padding: "20px" }}>
      <h1>CRUD Productos</h1>

      <input
        placeholder="Nombre"
        value={nombre}
        onChange={(e) => setNombre(e.target.value)}
      />

      <input
        placeholder="Precio"
        value={precio}
        onChange={(e) => setPrecio(e.target.value)}
      />

      <button onClick={crearProducto}>Agregar</button>

      <ul>
        {productos.map((p) => (
          <li key={p.id}>
            {p.nombre} - ${p.precio}
            <button onClick={() => eliminarProducto(p.id)}>
              Eliminar
            </button>
          </li>
        ))}
      </ul>
    </div>
  );
}

export default App;