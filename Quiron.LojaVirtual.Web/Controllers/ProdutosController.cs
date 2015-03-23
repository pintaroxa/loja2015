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
        private ProdutosRepositorio _repositorio; 

        // GET: Produtos
        public ActionResult Index()
        {


            _repositorio = new ProdutosRepositorio();
            
            // variavel que traz 10 iteis da tabela produto.
            var produtos = _repositorio.tblProdutos.Take(10);
                       

            return View(produtos);
        }
    }
}