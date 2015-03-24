using Quiron.LojaVirtual.Web.Models;
using System;
using System.Text;
using System.Web.Mvc;

namespace Quiron.LojaVirtual.Web.HtmlHelpers
{
    public static class PaginacaoHelpers
    {
               // montando um mvc e um delegate para paginação das strings
         public static MvcHtmlString PageLinks(this HtmlHelper html, Paginacao paginacao, Func<int, string> paginaurl)
        {
                // stringbuilder resultado final - estancia.
            StringBuilder resultado = new StringBuilder();

                // usando um for para montar as string de texto ex.. montando 3 x
            for (int i = 1; i < paginacao.TotalPagina; i++)
              {
                // classe que monta as tags, trazendo a primeira tag para criar "a"
                TagBuilder tag = new TagBuilder("a");

                // adicionando o atributo para o "a" //recebendo minha paginanaURL passando o I
                tag.MergeAttribute("href", paginaurl(i));
                
                //selecionando dentro do href a posição do cara.. exp. vai ser o "I"
                tag.InnerHtml = i.ToString();

                // usando bootstrep para subrinhar o texto do botão..
                if (i == paginacao.PaginaAtual)
                    {
                        // add as classes do boot strep.
                        tag.AddCssClass("selected");
                        tag.AddCssClass("btn-Primary");
                    }

                        // se não for
                        tag.AddCssClass("btn btn-Default");
                        resultado.Append(tag);
               }

            // retornando e criando o mvc do mesmo tipo.
            return MvcHtmlString.Create(resultado.ToString());

        }
    }
}