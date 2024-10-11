using Microsoft.AspNetCore.Mvc;
using REST_05_EF_Videoteche_Ref.Models;
using REST_05_EF_Videoteche_Ref.Services;

namespace REST_05_EF_Videoteche_Ref.Controllers
{
    [ApiController]
    [Route("api/supporti")]

    public class SupportoController : Controller
    {
        //Inietto l'istanza del service nel controller
        private readonly SupportoService _service;
        public SupportoController(SupportoService service) {
            _service = service;
        }

        [HttpGet("{varCodice}")]
        public ActionResult<SupportoDTO?> GetByCodice(string varCodice) {
            if (string.IsNullOrWhiteSpace(varCodice))
                return BadRequest("Il valore è nullo o ha spazi bianchi");

            SupportoDTO? supportoTrovato = _service.Cerca(varCodice);
            if (supportoTrovato is not null)
                return Ok(supportoTrovato);

            return NotFound();
        }

        [HttpGet]
        public ActionResult<List<SupportoDTO>> GetAllSupporti()
        {
            List<SupportoDTO> elencoSupportiDTO = _service.Lista();
            if (elencoSupportiDTO is not null) {
                return Ok(elencoSupportiDTO);
            }
            return NotFound();
        }

        [HttpDelete("{varCodice}")]
        public IActionResult DeleteSupporto(string varCodice) {

            if (string.IsNullOrWhiteSpace(varCodice))
                return BadRequest();
            
            if(_service.EliminaSupporto(varCodice))
                return Ok("Supporto eliminato");

            return NotFound("Supportazio non trovato o eliminato in precedenza");

        }








    }
}
