using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration.Conventions;
using Quiron.LojaVirtual.Dominio.Entidades;

namespace Quiron.LojaVirtual.Dominio.Repositorio
{
   
    // classe que referencia do entity dbcontext.
    //Constrói uma nova instância do contexto usando convenções para criar o nome do banco de dados para que a conexão será feita. 
    
    public class EfdbContex : DbContext
    {
             
        // Mapeando a classe de produto para o entity.
        // dbset é todas as referencias do banco.

        public DbSet<Produto> tblProduto { get; set; }

         ////////////////////////////////////////////////////////////////////////////////////////
        // criar um metodo para subscrever texto. exp. plurarização. remover!!

        // obS::: importante, pois o banco precisa saber quem é produto.

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
          
            modelBuilder.Conventions.Remove<PluralizingEntitySetNameConvention>();
            modelBuilder.Entity<Produto>().ToTable("tblProduto");
        }
    

        ////////////////////////////////////////////////////////////////////////////////////////////
    }
}
