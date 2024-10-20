using Business_Logic.Models.DTO;
using Business_Logic.Services;
using Microsoft.AspNetCore.Mvc;

namespace Business_Logic.Controllers
{
    [ApiController]
    [Route("api/pacchetti")]

    public class PacchettoVacanzaController : Controller
    {
        private readonly PacchettoVacanzaService _service;
        public PacchettoVacanzaController(PacchettoVacanzaService service) { 
            _service = service;
        }

        [HttpGet]
        public ActionResult<List<PacchettoVacanzaDTO>> MostraTuttiPacchetti() {

            List<PacchettoVacanzaDTO> elencoPacchetti = _service.Lista();

            if (elencoPacchetti is not null) { 
                return Ok(elencoPacchetti);
            }

            return BadRequest("Non ci sono pacchetti");

        }
    }
}
