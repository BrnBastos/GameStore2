using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using GameStore.Models;
using GameStore.Repositorio;
using System.Web.Mvc;

namespace GameStore.Controllers
{
    public class ClienteController : Controller
    {
        // GET: Client
        public ActionResult Cliente()
        {
            //var cliente = new Cliente();
            return View();
        }
        Acoes ac = new Acoes();


        [HttpPost]
        public ActionResult Cliente(Cliente cliente)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    ac.CadastrarCliente(cliente);
                    return RedirectToAction("ListarCliente");
                }
                return View(cliente);
            }
            catch
            {
                return RedirectToAction("Cliente");
            }

        }

        public ActionResult ListarCliente()
        {
            var ExibirCliente = new Acoes();
            var TodosCli = ExibirCliente.ListarCliente();
            return View(TodosCli);
        }
    }
    
}