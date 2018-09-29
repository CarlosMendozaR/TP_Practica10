using System;

namespace Eventos
{
    class Productos
    {
        public string nombre;
        public string cantidad;
        public float precio;

        public Productos(string nombre, string cantidad, float precio)
        {
            this.nombre = nombre;
            this.cantidad = cantidad;
            this.precio = precio;
        }
    }
}
