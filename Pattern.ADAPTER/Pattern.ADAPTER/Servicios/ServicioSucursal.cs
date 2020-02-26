using Pattern.ADAPTER.Entidades;
using Pattern.ADAPTER.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.ADAPTER.Servicios
{
    public class ServicioSucursal : ISucursal
    {
        public void ObtenerTodos(List<SucursalesDTO> _SucursalesDTO)
        {
            foreach (SucursalesDTO item in _SucursalesDTO)
            {
                Console.WriteLine("Id = {0}    Sucursal = {1}    TotalVentas = {2}", item.iIdSucursal, item.cNombreSucurdal, item.iTotalVentas);
            }
        }
    }
}
