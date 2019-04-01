using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SisVentas.DB;
using SisVentas.Models;
using System.Data.Entity;

namespace SisVentas.Controllers
{
    public class FacturaController : Controller
    {
        VentaContext context = new VentaContext();

        public ViewResult Index()
        {
            var facturas = context.Facturas
                .ToList();

            return View("Index", facturas);
        }

        public ViewResult FormGuardar()
        {
            ViewBag.Clientes = context.Clientes
                .ToList();
            return View("FormGuardar", new Factura());
        }

        public ActionResult Guardar(Factura factura)
        {
            if (!ModelState.IsValid)
            {
                return View("FormGuardar", factura);
            }
            context.Facturas.Add(factura);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        public ViewResult FormEditar(int id)
        {
            var model = context.Facturas
                .Where(o => o.Id == id)
                .FirstOrDefault();
            return View("formEditar", model);
        }

        public RedirectToRouteResult Actualizar(Factura factura)
        {
            Factura facturaDB = context.Facturas
                .Where(o => o.Id == factura.Id)
                .FirstOrDefault();
            facturaDB.IdCliente = factura.IdCliente;
            facturaDB.Fecha = factura.Fecha;
            facturaDB.IdModoPago = factura.IdModoPago;
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        public RedirectToRouteResult Eliminar(int id)
        {
            var factura = context.Facturas
                .Where(o => o.Id == id)
                .FirstOrDefault();
            context.Facturas.Remove(factura);
            context.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}