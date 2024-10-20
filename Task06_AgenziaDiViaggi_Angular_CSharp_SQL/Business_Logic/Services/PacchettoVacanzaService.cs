using Business_Logic.Models;
using Business_Logic.Models.DTO;
using Business_Logic.Repos;

namespace Business_Logic.Services
{
    public class PacchettoVacanzaService : IService<PacchettoVacanzaDTO>
    {
        private readonly PacchettoVacanzaRepo _repo;
        public PacchettoVacanzaService(PacchettoVacanzaRepo repo) { 
            _repo = repo;
        }

        public PacchettoVacanzaDTO? Cerca(string varCod)
        {
            throw new NotImplementedException();
        }

        public List<PacchettoVacanzaDTO> Lista()
        {
            List<PacchettoVacanzaDTO> pacchettiDTO = new List<PacchettoVacanzaDTO>();
            IEnumerable<PacchettoVacanza> elencoPacchettiRepo = _repo.GetAll();

            foreach (PacchettoVacanza pacco in elencoPacchettiRepo) {
                if (pacco is not null) {
                    PacchettoVacanzaDTO paccoDTO = new PacchettoVacanzaDTO()
                    {
                        cod = pacco.Codice,
                        nom = pacco.Nome,
                        pri = pacco.Prezzo,
                        dur = pacco.Durata,
                        ini = pacco.Data_Inizio,
                        fin = pacco.Data_Fine
                    };
                    pacchettiDTO.Add(paccoDTO);
                }
            }

            return pacchettiDTO;
        }
    }
}
