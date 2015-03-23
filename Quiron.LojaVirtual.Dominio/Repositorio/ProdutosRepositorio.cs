using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Quiron.LojaVirtual.Dominio.Entidades;

namespace Quiron.LojaVirtual.Dominio.Repositorio
{
    public class ProdutosRepositorio
    {
        // variavel para referenciar o entity
        private readonly EfdbContex _context = new EfdbContex();

        //propriedade enumerada que retorna produtos
        //Expõe um enumerador, que oferece suporte a uma iteração simples sobre uma coleção não genérico.
        public IEnumerable<Produto> tblProdutos
        {
            // retornando o context do produto.
            get { return _context.tblProdutos; }
        }
    }
}
