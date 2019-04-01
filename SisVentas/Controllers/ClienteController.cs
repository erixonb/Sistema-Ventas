using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SisVentas.DB;
using SisVentas.Models;

namespace SisVentas.Controllers
{
    public class ClienteController : Controller
    {
        VentaContext context = new VentaContext();

        public ActionResult Index()
        {
            var clientes = context.Clientes
                .ToList();
            return View("Index", clientes);
        }

        public ActionResult FormGuardar()
        {
            return View("formGuardar", new Cliente());
        }

        public ActionResult Guardar(Cliente cliente)
        {
            if (!ModelState.IsValid)
            {
                return View("FormGuardar", cliente);
            }

            context.Clientes.Add(cliente);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult FormEditar(int id)
        {
            var model = context.Clientes
                .Where(o => o.Id == id)
                .FirstOrDefault();
            return View("FormEditar", model);
        }

        public RedirectToRouteResult Actualizar(Cliente cliente)
        {
            var clienteDB = context.Clientes
                .Where(o => o.Id == cliente.Id)
                .FirstOrDefault();
            clienteDB.Nombre = cliente.Nombre;
            clienteDB.Apellido = cliente.Apellido;
            clienteDB.Direccion = cliente.Direccion;
            clienteDB.FechaNac = cliente.FechaNac;
            clienteDB.Email = cliente.Email;

            context.SaveChanges();
            return RedirectToAction("Index");
        }

        public RedirectToRouteResult Eliminar(int id)
        {
            var cliente = context.Clientes
                .Where(o => o.Id == id)
                .FirstOrDefault();
            context.Clientes.Remove(cliente);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}