using Microsoft.AspNetCore.Mvc; 

namespace Tarefas.Web.Controllers
{
    public class TarefaController : Controller{

        public IActionResult Create(){
            return View();
        }
    }
}