using Pattern.ADAPTER.Entidades;
using Pattern.ADAPTER.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.ADAPTER.Servicios
{
    public class ServicioConcreto
    {
        public ISucursal sucursal;

        public ServicioConcreto(ISucursal _sucursal)
        {
            this.sucursal = _sucursal;
        }

        public void generar(List<SucursalesDTO> _SucursalesDTO)
        {
            this.sucursal.ObtenerTodos(_SucursalesDTO);
        }
    }
}
