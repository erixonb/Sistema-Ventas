using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SisVentas.DB;
using SisVentas.Models;

namespace SisVentas.Controllers
{
    public class VentaControler : Controller
    {
        public ActionResult NuevaFactura()
        {
            FacturaView facturaview = new FacturaView();
            facturaview.Clientes = new ClienteFactura();
            facturaview.Productos = new List<ProductoFactura>();
            return View(facturaview);
        }
        
    }
}