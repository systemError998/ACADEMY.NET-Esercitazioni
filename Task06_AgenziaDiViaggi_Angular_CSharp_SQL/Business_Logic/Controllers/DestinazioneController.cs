using Business_Logic.Models;
using Business_Logic.Models.DTO;
using Business_Logic.Services;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace Business_Logic.Controllers
{
    [ApiController]
    [Route("api/destinazioni")]
    public class DestinazioneController : Controller
    {
        private readonly DestinazioneService _service;
        public DestinazioneController(DestinazioneService service) { 
            _service = service;
        }

        [HttpGet]
        public ActionResult<List<DestinazioneDTO>> MostraTutteDestinazioni() { 

            List<DestinazioneDTO> elencoDestinazioni = _service.Lista();

            if (elencoDestinazioni is not null) {
                return Ok(elencoDestinazioni);
            }

            return BadRequest("Non ci sono destinazioni");

        }
    }
}
