using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace agarera.Servicios
{
    internal class menuImplementacion : menuInterfaz
    {
        public int mostrarMenuYSeleccion()
        {
            int opcionSeleccion;

            Console.WriteLine("-------------------------");
            Console.WriteLine("|0. Cerrar menu         |");
            Console.WriteLine("|1. Dar alta cuberteria |");
            Console.WriteLine("|2. Borrar cuberteria   |");
            Console.WriteLine("|3. Modificar cuberteria|");
            Console.WriteLine("|4. Ver cuberteria      |");
            Console.WriteLine("-------------------------");
            Console.WriteLine("Selecciones una opcion");

            opcionSeleccion = Console.ReadKey(true).KeyChar - ('0');

            return opcionSeleccion;


        }
    }
}
