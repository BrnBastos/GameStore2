using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using GameStore.Models;
using System.Web.Mvc;

namespace GameStore.Controllers
{
    public class JogoController : Controller
    {
        // GET: Jogo
        public ActionResult Index()
        {
            Jogo jog = new Jogo()
            {
                JogCod = 154,
                JogNome = "God of War",
                JogVersao = "Deluxe",
                JogDev = "sonyPictures",
                JogGen = "quarta geração",
                JogFE = "14 anos",
                JogPlat = "playstation 4 e 5",
                JogAno = 2017,
                JogSinopse = "Um semi deus grego vai para o mundo nordico fugindo de seu passado, e é lá onde ele se casa e tem um filho, porém os deuses daquele mundo não ficam tão felizes assim com sua presença"
            };

            return View(jog);

        }
        [HttpPost]
        public ActionResult Listar(Jogo jog)
        {

            return View(jog);

        }
    }

}