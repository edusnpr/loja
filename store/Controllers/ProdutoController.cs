using Microsoft.AspNetCore.Mvc;
using store.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace store.Controllers
{
    public class ProdutoController : Controller
    {
        public ActionResult Visualizar()
        {
            Produto produto =  GetProduto();
            return View(produto);

            /*
            return new ContentResult()
            {
                Content = "<h3>Produto -> Visualizar</h3>",
                ContentType = "text/html"
            };
            */
        }

        private Produto GetProduto()
        {
            return new Produto()
            {
                Id = 1,
                Nome = "Xbox One X",
                Descricao = "Console Xbox One X",
                //M é decimal
                Valor = 2000.00M
            };
        }
    }
}
