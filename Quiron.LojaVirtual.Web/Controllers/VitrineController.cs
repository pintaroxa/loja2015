using Quiron.LojaVirtual.Dominio.Repositorio;
using System.Linq;
using System.Web.Mvc;


namespace Quiron.LojaVirtual.Web.Controllers
{
    public class VitrineController : Controller
    {

        // variavel que representa a lista de produto do repositório
       

        // variavel que representa a pagina
       
        // GET: Vitrine


        // metodo que recebe um numero de pagina = 1
        public ActionResult index()
        {
            // variavel que recebe a lista de produto.
        
                // ordenando usando lambda expresion por nome.
        
                //ignorando as primeiras paginas usando o skip e multiplicando pelo produto por pagina....
                
                // trazendo os 06 paginas que estão na frente.
                
            return View();

        }
    }
}