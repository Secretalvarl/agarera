using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace agarera.Dtos
{
    internal class ClienteDto
    {
        long id;

        string nombre;

        string descripcion;

        int cantidad;

        public long Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }


        public ClienteDto(long id, string nombre, string descripcion, int cantidad)
        {
            this.id = id;
            this.nombre = nombre;
            this.descripcion = descripcion;
            this.cantidad = cantidad;
        }

        public ClienteDto()
        {
        }

        public string ToString()
        {
            string cuberteria = "  " + id + "\n  " + id + nombre + "\n  " 
                + nombre + "\n  " + descripcion +  "\n  " + cantidad;
            
            return cuberteria;
        }

    }

    
}
