using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Quiron.LojaVirtual.Dominio.Repositorio;

namespace Quiron.LojaVirtual.Web.Controllers
{
    public class VitrineController : Controller
    {

        // variavel que representa a lista de produto do repositorio
        private ProdutosRepositorio _repositorio = new ProdutosRepositorio();


        // variavel que representa a pagina
        private int ProdutoPorPagina = 6;


        // GET: Vitrine


        // metodo que recebe um numero de pagina = 1
        public ActionResult ListaProduto(int pagina = 1)
        {
            // variavel que recebe a lista de produto.
            var produto = _repositorio.tblProduto

                // ordenando usando lambda expresion por nome.
                .OrderBy(p => p.Descricao)

                //ignorando as primeiras paginas usando o skip e mutilplicando pelo produto por pagina....
                .Skip((pagina - 1) * ProdutoPorPagina)

                // trazendo os 06 paginas que estão na frente.
                .Take(ProdutoPorPagina);
 
            return View(produto);
        }
    }
}