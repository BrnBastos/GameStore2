using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using GameStore.Models;
using System.Web.Mvc;

namespace GameStore.Controllers
{
    public class ClienteController : Controller
    {
        // GET: Client
        public ActionResult Index()
        {
            Cliente client = new Cliente()
            {
                ClientNome = "Armando Silva",
                ClientCPF = "123.456.789-10",
                ClientDTN = "19/11/1998",
                ClientEmail = "armando@email.com",
                ClientCelular = "11 91234-5678",
                ClientEndereco = "rua astolfo silva 430",
            };

            return View(client);
        }
        [HttpPost]
        public ActionResult Listar(Cliente client)
        {

            return View(client);

        }
    }
    
}