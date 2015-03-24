using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Quiron.LojaVirtual.Dominio.Repositorio;


namespace Quiron.LojaVirtual.Web.Controllers
{
    public class ProdutosController : Controller
    {


        // representa a instancia da tabela de produtos do repositorio.
             private ProdutosRepositorio _repositorio = new ProdutosRepositorio();

        // GET: Produtos
        public ActionResult Index()
        {
                  
            // variavel que traz 10 iteis da tabela produto.
            var produtos = _repositorio.tblProduto.Take(10);
                       

            return View(produtos);
        }
    }
}