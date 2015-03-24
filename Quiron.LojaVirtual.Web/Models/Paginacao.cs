using System;

namespace Quiron.LojaVirtual.Web.Models
{
    public class Paginacao
    {

        //Quantos Itens tenho  no banco
        public int ItensTotal { get; set; }

        //Quantos Itens quero por pagina
        public int ItensPorPagina { get; set; }

        //Qual Pagina que esta sendo exibida no momento
        public int PaginaAtual { get; set; }

        //Quantidade itens tenho na paginas 
        public int TotalPagina
        {

            get 
            {
                // propriedade MAth.Ceiling arredonda o valor para cima..
                return (int)Math.Ceiling((decimal)ItensTotal / ItensPorPagina); 
            } 
                       
        }
    }
}