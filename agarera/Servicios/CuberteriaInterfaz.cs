using agarera.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace agarera.Servicios
{
    /// <summary>
    /// Catalogo de metodos que gestiona el alta, el borrado y el modificado de la cuberteria
    /// 24/12/2023 - agb
    /// </summary>
    internal interface CuberteriaInterfaz
    {
        /// <summary>
        /// Metodo para dar de alta cuberteria
        /// 24/12/2023 - agb
        /// </summary>
        /// <param name="listaAntigua"></param>
        public void agregarCuberteria(List<ClienteDto> listaAntigua);

        /// <summary>
        /// Metodo para borrar cuberterria
        /// 24/12/2023 - agb
        /// </summary>
        /// <param name="listaAntigua"></param>

        public void borrarCuberteriaList(List<ClienteDto> listaAntigua);

    }
}
