using System.Linq;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Web;
using System;

namespace Quiron.LojaVirtual.UnitTest
{
    [TestClass]
    public class UnitTestQuiron
    {
        [TestMethod]
        public void Take()
        {
            // O Operador Take é usado para selecionar os primeiros objetos de uma coleção

            int[] numeros = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };



            var resultado = from num in numeros.Take(5) select num;

            int[] teste = { 5, 4, 1, 3, 9 };


            // fazendo a comparação se o resultado é igual ao teste.
            CollectionAssert.AreEqual(resultado.ToArray(), teste);


        }


        [TestMethod]

        public void Skip()
        {
            // O Operador Skip ignora os primeiros objetos de uma coleção.
            int[] numeros = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            var resultado = from num in numeros.Take(5).Skip(2) select num;

            int[] teste = { 1, 3, 9 };

            // fazendo a comparação se o resultado é igual ao teste.
            CollectionAssert.AreEqual(resultado.ToArray(), teste);
        }


        // classe geradora de html

        [TestMethod]
        public void TestePaginacaoHtml()
        {

            HtmlHelper html = null;



            Paginacao paginacao = new Paginacao
            {
                PaginaAtual = 2,
                ItensPorPaginas = 10,
                ItensTotal = 2

            };

            Func<int, string> paginaUrl = i => "Pagina" + i;



        }


    }
}
