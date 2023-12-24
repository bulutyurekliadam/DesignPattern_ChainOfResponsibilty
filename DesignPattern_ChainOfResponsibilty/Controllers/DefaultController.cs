using DesignPattern_ChainOfResponsibilty.ChainOfResponsibility;
using DesignPattern_ChainOfResponsibilty.Models;
using Microsoft.AspNetCore.Mvc;

namespace DesignPattern_ChainOfResponsibilty.Controllers
{
    public class DefaultController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(CustomerProcessViewModel model)
        {
            Employee treasurer = new Treasurer();
            Employee managerAssistant = new ManagerAssistant();
            Employee manager = new Manager();
            Employee areaDirector = new AreaDirector();

            treasurer.SetNextAppRover(managerAssistant);
            managerAssistant.SetNextAppRover(manager);
            manager.SetNextAppRover(areaDirector);

            treasurer.ProcessRequest(model);
            return View();
        }
    }
}
