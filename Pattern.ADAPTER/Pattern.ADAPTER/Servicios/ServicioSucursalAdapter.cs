using Pattern.ADAPTER.Entidades;
using Pattern.ADAPTER.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Pattern.ADAPTER.Servicios
{
    public class ServicioSucursalAdapter : ISucursal
    {
        public void ObtenerTodos(List<SucursalesDTO> _SucursalesDTO)
        {
            Console.WriteLine(JsonConvert.SerializeObject(_SucursalesDTO));
        }
    }
}
