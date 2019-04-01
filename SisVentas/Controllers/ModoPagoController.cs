using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SisVentas.DB;
using SisVentas.Models;

namespace SisVentas.Controllers
{
    public class ModoPagoController : Controller
    {
        VentaContext context = new VentaContext();

        public ActionResult Index()
        {
            var modopagos = context.ModoPagos
                .ToList();

            return View("Index", modopagos);
        }

        public ViewResult FormGuardar()
        {
            return View("FormGuardar", new ModoPago());
        }

        public ActionResult Guardar(ModoPago modopago)
        {
            if (!ModelState.IsValid)
            {
                return View("FormGuardar", modopago);
            }
            context.ModoPagos.Add(modopago);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        public ViewResult FormEditar(int id)
        {
            var model = context.ModoPagos
                .Where(o => o.IdPago == id)
                .FirstOrDefault();
            return View("formEditar", model);
        }

        public RedirectToRouteResult Actualizar(ModoPago modopago)
        {
            ModoPago pagoDB = context.ModoPagos
                .Where(o => o.IdPago == modopago.IdPago)
                .FirstOrDefault();
            pagoDB.Nombre = modopago.Nombre;
            pagoDB.OtrosDetalles = modopago.OtrosDetalles;
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        public RedirectToRouteResult Eliminar(int id)
        {
            var modopago = context.ModoPagos
                .Where(o => o.IdPago == id)
                .FirstOrDefault();
            context.ModoPagos.Remove(modopago);
            context.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}