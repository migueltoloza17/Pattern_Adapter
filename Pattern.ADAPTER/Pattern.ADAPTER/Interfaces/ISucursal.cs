using Pattern.ADAPTER.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.ADAPTER.Interfaces
{
    public interface ISucursal
    {
        void ObtenerTodos(List<SucursalesDTO> _SucursalesDTO);
    }
}
