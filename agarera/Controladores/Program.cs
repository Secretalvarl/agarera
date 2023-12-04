using agarera.Dtos;
using agarera.Servicios;
using System.Runtime.ConstrainedExecution;

namespace agarera.Controladores
{
    /// <summary>
    /// Clase principal de nuestra aplicacion
    /// 04/12/2023-agb
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Control de nuestra aplicacion
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            List<ClienteDto> listaCuberteria = new List<ClienteDto>();

            menuInterfaz alpha = new menuImplementacion();
            CuberteriaInterfaz omega = new CuberteriaImplementacion();

            bool cerrarMenu = false;
            int opcionSeleccion;

            while(!cerrarMenu)
            {
                opcionSeleccion = alpha.mostrarMenuYSeleccion();
                Console.WriteLine(opcionSeleccion);

                switch(opcionSeleccion) 
                { 
                    case 0:
                        Console.WriteLine("menu cerrado");
                        cerrarMenu = true;
                        break;
                    case 1:
                        Console.WriteLine(" Dar alta cuberteria");
                        omega.agregarCuberteria(listaCuberteria);
                        foreach (ClienteDto cuberteria in listaCuberteria)
                        {
                            Console.WriteLine(cuberteria.ToString());
                        }
                        break; 
                    case 2:
                        Console.WriteLine("Borrar cuberteria");
                        break;
                    case 3:
                        Console.WriteLine("Modificar cuberteria");
                        omega.borrarCuberteriaList(listaCuberteria);
                        foreach (ClienteDto cuberteria in listaCuberteria)
                        {
                            Console.WriteLine(cuberteria.ToString());
                        }
                        break;
                    case 4:
                        Console.WriteLine("Ver cuberteria");
                        foreach (ClienteDto cuberteria in listaCuberteria)
                        {
                            Console.WriteLine(cuberteria.ToString());
                        }
                        break;
                    default:
                        break;


                
                }
            }
        }
    }
}