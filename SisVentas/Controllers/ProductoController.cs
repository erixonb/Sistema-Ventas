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
    public class ProductoController : Controller
    {
        VentaContext context = new VentaContext();

        public ViewResult Index()
        {
            var productos = context.Productos
                .Include(o => o.Categorias)
                .ToList();

            return View("Index", productos);
        }

        public ViewResult FormGuardar()
        {
            ViewBag.Categorias = context.Categorias
                .ToList();
            return View("FormGuardar", new Producto());
        }

        public ActionResult Guardar(Producto producto)
        {
            if (!ModelState.IsValid)
            {
                return View("FormGuardar", producto);
            }
            context.Productos.Add(producto);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        public ViewResult FormEditar(int id)
        {
            var model = context.Productos
                .Where(o => o.Id == id)
                .FirstOrDefault();
            return View("formEditar", model);
        }

        public RedirectToRouteResult Actualizar(Producto producto)
        {
            Producto productoDB = context.Productos
                .Where(o => o.Id == producto.Id)
                .FirstOrDefault();
            productoDB.Nombre = producto.Nombre;
            productoDB.Precio = producto.Precio;
            productoDB.IdCategoria = producto.IdCategoria;
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        public RedirectToRouteResult Eliminar(int id)
        {
            var producto = context.Productos
                .Where(o => o.Id == id)
                .FirstOrDefault();
            context.Productos.Remove(producto);
            context.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}