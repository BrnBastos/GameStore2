using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GameStore.Models
{
    public class Jogo
    {
        public ushort JogCod { get; set; }
        public string JogNome { get; set; }
        public string JogVersao { get; set; }
        public string JogDev { get; set; }
        public string JogGen { get; set; }
        public string JogFE { get; set; }
        public string JogPlat { get; set; }
        public int JogAno { get; set; }
        public string JogSinopse { get; set; }

    }
    


}