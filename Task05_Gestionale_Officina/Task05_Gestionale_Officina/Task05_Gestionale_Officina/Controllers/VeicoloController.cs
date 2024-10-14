using Microsoft.AspNetCore.Mvc;
using Task05_Gestionale_Officina.Models.DTO;

namespace Task05_Gestionale_Officina.Controllers
{
    [ApiController]
    [Route("api/veicoli")]
    public class VeicoloController : Controller
    {
        public VeicoloController() { }

        [HttpGet("{varCodice}")]
        public ActionResult<VeicoloDTO> VisualizzaDettaglioVeicolo(string varCodice)
        {
            return View();
        }

        [HttpPost]
        public IActionResult InserisciVeicolo(VeicoloDTO veicoloDTO)
        { 
            if(_service.)
        }
    }
}
