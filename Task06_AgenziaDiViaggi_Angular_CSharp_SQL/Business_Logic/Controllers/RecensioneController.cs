using Business_Logic.Models;
using Business_Logic.Models.DTO;
using Business_Logic.Services;
using Microsoft.AspNetCore.Mvc;

namespace Business_Logic.Controllers
{
    [ApiController]
    [Route("api/recensioni")]
    public class RecensioneController : Controller
    {
        private readonly RecensioneService _service;
        public RecensioneController(RecensioneService service) {
            _service = service;
        }

        [HttpGet]
        public ActionResult<List<RecensioneDTO>> MostraTutteRecensioni() {

            List<RecensioneDTO> elencoRecensioni = _service.Lista();

            if (elencoRecensioni is not null) {
                return Ok(elencoRecensioni);
            }

            return BadRequest("Non ci sono recensioni");

        }
    }
}
