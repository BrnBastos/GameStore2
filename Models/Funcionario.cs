using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GameStore.Models
{
    public class Funcionario
    {
        public ushort FuncCod { get; set; }
        public string FuncNome { get; set; }
        public string FuncCPF { get; set; }
        public string FuncRG { get; set; }
        public string FuncDTN { get; set; }
        public string FuncEndereco { get; set; }
        public string FuncCelular { get; set; }
        public string FuncEmail { get; set; }
        public string FuncCargo { get; set; }


    }
}