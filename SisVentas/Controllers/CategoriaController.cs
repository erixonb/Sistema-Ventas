using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SisVentas.DB;
using SisVentas.Models;

namespace SisVentas.Controllers
{
    public class CategoriaController : Controller
    {
        VentaContext context = new VentaContext();

        public ActionResult Index()
        {
            var categorias = context.Categorias
                .ToList();

            return View("Index", categorias);
        }

        public ViewResult FormGuardar()
        {
            return View("FormGuardar", new Categoria());
        }

        public ActionResult Guardar(Categoria categoria)
        {
            if (!ModelState.IsValid)
            {
                return View("FormGuardar", categoria);
            }
            context.Categorias.Add(categoria);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        public ViewResult FormEditar(int id)
        {
            var model = context.Categorias
                .Where(o => o.Id == id)
                .FirstOrDefault();
            return View("formEditar", model);
        }

        public RedirectToRouteResult Actualizar(Categoria categoria)
        {
            Categoria categoriaDB = context.Categorias
                .Where(o => o.Id == categoria.Id)
                .FirstOrDefault();
            categoriaDB.Nombre = categoria.Nombre;
            categoriaDB.Descripcion = categoria.Descripcion;
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        public RedirectToRouteResult Eliminar(int id)
        {
            var categoria = context.Categorias
                .Where(o => o.Id == id)
                .FirstOrDefault();
            context.Categorias.Remove(categoria);
            context.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}