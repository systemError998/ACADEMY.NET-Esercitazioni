using Microsoft.AspNetCore.Mvc;
using Task05_Gestionale_Officina.Models.DTO;

namespace Task05_Gestionale_Officina.Controllers
{
    public class ClienteController : Controller
    {
        public ActionResult VisualizzaCliente()
        {
            return View();
        }
        //public IActionResult AggiornaCliente(string varCod, ClienteDTO cltDTO)
        //{
        //    if (string.IsNullOrWhiteSpace(varCod) ||
        //      (string.IsNullOrWhiteSpace(cltDTO.Nom)) ||
        //      (string.IsNullOrWhiteSpace(cltDTO.Cog)) ||
        //      (string.IsNullOrWhiteSpace(cltDTO.Ema)) ||
        //      (string.IsNullOrWhiteSpace(cltDTO.Tel)) ||
        //      (string.IsNullOrWhiteSpace(cltDTO.Ind))
        //      ) ;
        //}
    }
}
