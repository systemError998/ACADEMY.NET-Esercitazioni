using Business_Logic.Models;
using Business_Logic.Models.DTO;
using Business_Logic.Repos;

namespace Business_Logic.Services
{
    public class RecensioneService : IService<RecensioneDTO>
    {
        private readonly RecensioneRepo _repo;
        public RecensioneService(RecensioneRepo repo) {
            _repo = repo;
        }

        public RecensioneDTO? Cerca(string varCod)
        {
            throw new NotImplementedException();
        }

        public List<RecensioneDTO> Lista()
        {
            List<RecensioneDTO> recensioniDTO = new List<RecensioneDTO>();
            IEnumerable<Recensione> elencoRecensioni = _repo.GetAll();

            foreach (Recensione rec in elencoRecensioni) {
                if (rec is not null) {
                    RecensioneDTO recDTO = new RecensioneDTO() {
                        codi = rec.Codice,
                        uten = rec.NomeUtente,
                        voto = rec.Voto,
                        text = rec.Commento,
                        data = rec.DataRecensione,
                        pacchettoRIF = rec.PacchettoRIF
                    };
                    recensioniDTO.Add(recDTO);
                }
            }
            return recensioniDTO;
        }
    }
}
