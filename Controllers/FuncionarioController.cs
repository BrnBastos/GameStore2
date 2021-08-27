using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GameStore.Models;
namespace GameStore.Controllers
{
    public class FuncionarioController : Controller
    {
        // GET: Funcionario
        public ActionResult Index()
        {
            Funcionario func = new Funcionario()
            {
                FuncCod = 1,
                FuncNome = "Guilherme Braga",
                FuncCPF = "123.456.789-10",
                FuncRG = "12 345 678-9",
                FuncDTN = "00/00/0000",
                FuncEndereco = "Rua do carmo 778",
                FuncCelular = "11 91234-5678",
                FuncEmail = "guilherme@email.com",
                FuncCargo = "estoquista" 
            };

            return View(func);

        }
        [HttpPost]
        public ActionResult Listar(Funcionario funcionario)
        {
        
            return View(funcionario);

        }
    }

    


}