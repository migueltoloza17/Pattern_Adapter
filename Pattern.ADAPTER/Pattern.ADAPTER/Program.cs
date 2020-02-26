using Pattern.ADAPTER.Entidades;
using Pattern.ADAPTER.Interfaces;
using Pattern.ADAPTER.Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.ADAPTER
{
    class Program
    {
        static void Main(string[] args)
        {
            List<SucursalesDTO> lstSucursales = new List<SucursalesDTO>();
            ISucursal sucursal = new ServicioSucursalAdapter();
            lstSucursales.Add(new SucursalesDTO { iIdSucursal = 1, cNombreSucurdal = "Sucursal 01", iTotalVentas = 1500 });
            lstSucursales.Add(new SucursalesDTO { iIdSucursal = 2, cNombreSucurdal = "Sucursal 02", iTotalVentas = 2500 });
            lstSucursales.Add(new SucursalesDTO { iIdSucursal = 3, cNombreSucurdal = "Sucursal 03", iTotalVentas = 1800 });

            ServicioConcreto svrServicio = new ServicioConcreto(sucursal);
            svrServicio.generar(lstSucursales);

            Console.ReadKey();
        }
    }
}
