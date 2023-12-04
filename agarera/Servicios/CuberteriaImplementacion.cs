using agarera.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace agarera.Servicios
{
    internal class CuberteriaImplementacion : CuberteriaInterfaz
    {
        public void agregarCuberteria(List<ClienteDto> listaAntigua)
        {
            ClienteDto cliente = crearNuevaCuberteria();

            listaAntigua.Add(cliente);

        }

        private ClienteDto crearNuevaCuberteria()
        {
            ClienteDto nuevaCuberteria = new ClienteDto();

            Console.WriteLine("Escriba la id");
            nuevaCuberteria.Id = Convert.ToInt64(Console.ReadLine());

            Console.WriteLine("Escriba el nombre");
            nuevaCuberteria.Nombre = Console.ReadLine();

            Console.WriteLine("Escriba la descripcion");
            nuevaCuberteria.Descripcion = Console.ReadLine();

            Console.WriteLine("Escriba la cantidad");
            nuevaCuberteria.Cantidad = Convert.ToInt32(Console.ReadLine());

            return nuevaCuberteria;

        }
        public string pedirCodigo()
        {
            Console.WriteLine("Escriba el codigo de la cuberteria");
            string cantidad = Console.ReadLine();

            return cantidad;
        }


        public void borrarCuberteriaList(List<ClienteDto> listaAntigua)
        {
            for (int control = 0; control <= listaAntigua.Count; control++)
            {
                string buscarBorrar = pedirCodigo();

                foreach (ClienteDto cliente in listaAntigua)
                {
                    if (cliente.Id.Equals(buscarBorrar))
                    {
                        Console.WriteLine("Dime la cantidad que quieres modificar");
                        int cantidadACambiar = Convert.ToInt32(Console.ReadLine());
                        break;
                    }
                    else 
                    {
                        Console.WriteLine("No hay ningun tipo de cuberteria con esa ID");
                    }


                }



            }


        }
    }
}
