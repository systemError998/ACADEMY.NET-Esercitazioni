using Microsoft.AspNetCore.Mvc;
using REST_05_EF_Videoteche_Ref.Models;
using REST_05_EF_Videoteche_Ref.Services;

namespace REST_05_EF_Videoteche_Ref.Controllers
{
    [ApiController]
    [Route("api/videoteche")]
    public class VideotecaController : Controller
    {
        private readonly VideotecaService _service;

        public VideotecaController(VideotecaService service)
        {
            _service = service;
        }

        [HttpGet("{varCodice}")]
        public ActionResult<VideotecaDTO?> CercaPerCodice(string varCodice) {
            if (string.IsNullOrWhiteSpace(varCodice))
                return BadRequest();
            
            VideotecaDTO? risultato = _service.Cerca(varCodice);
            if(risultato is not null)
                return Ok(risultato);

            return NotFound();
        }

        [HttpGet]
        public ActionResult<List<VideotecaDTO>> GetAllVideoteche() {

            List <VideotecaDTO> elencoVideotecheDTO = _service.Lista();
            if (elencoVideotecheDTO is not null) {
                return Ok(elencoVideotecheDTO);
            }
            return NotFound();
        }

        [HttpDelete("{varCodice}")]
        public IActionResult DeleteVideoteca(string varCodice)
        {
            if (string.IsNullOrWhiteSpace(varCodice))
                return BadRequest("La videoteca è null o ha degli spazi vuoti");

            if (_service.EliminaVideoteca(varCodice))
                return Ok("Videoteca eliminata");

            return NotFound("Questa videoteca io non l'ho mai vista ne sentita.");
        }

        [HttpPost]
        public IActionResult InserisciVideoteca(string varNome, string varInd)
        {
            if ((varNome is not null && varNome.Trim().Length < 3) || (varInd is not null && varInd.Trim().Length < 3))
                return BadRequest("Campi non validi.");

            VideotecaDTO nuovaVideoteca = new VideotecaDTO
            {
                Nom = varNome,
                Ind = varInd
            };

            if (_service.InserisciVideoteca(nuovaVideoteca))
                return Ok("Videoteca inserita con successo.");

            return BadRequest("Errore nell'inserimento.");
        }

        [HttpPut]
        public IActionResult ModificaVideoteca(string varCodice, string varNome, string varInd)
        {
            if (string.IsNullOrWhiteSpace(varCodice) || string.IsNullOrWhiteSpace(varNome) || string.IsNullOrWhiteSpace(varInd))
                return BadRequest("Inserisci un codice valido");

            VideotecaDTO videotecaMod = new VideotecaDTO
            {
                Cod = varCodice,
                Nom = varNome,
                Ind = varInd
            };
            if (_service.ModificaVideoteca(videotecaMod))
                return Ok("Videoteca modificata con successo");

            return BadRequest("Errore nella modifica della videoteca");
        }

    }
}
