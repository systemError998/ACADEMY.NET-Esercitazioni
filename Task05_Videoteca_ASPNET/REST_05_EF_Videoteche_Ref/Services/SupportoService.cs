using REST_05_EF_Videoteche_Ref.Models;
using REST_05_EF_Videoteche_Ref.Repos;

namespace REST_05_EF_Videoteche_Ref.Services
{
    public class SupportoService : IService<SupportoDTO>
    {
        private readonly SupportoRepo _repo;
        public SupportoService(SupportoRepo repo) {
            _repo = repo;
        }


        //METODI CRUD
        public SupportoDTO? Cerca(string varCod)
        {
            SupportoDTO? suppDTOtemp = null;

            Supporto? supporto = _repo.GetByCodice(varCod);

            if (supporto is not null)
            {
                suppDTOtemp = new SupportoDTO()
                {
                    codi = supporto.Codice,
                    tito = supporto.Titolo,
                    anno = supporto.Anno,
                    disp = supporto.Disponibilita,
                    tipo = supporto.Tipo
                };
            }

            return suppDTOtemp;
        }

        //all'utente restituisco la lista di SUPPORTI DTO 
        public List<SupportoDTO> Lista()
        {
            List<SupportoDTO> risultato = new List<SupportoDTO>();

            IEnumerable<Supporto> elencoSupporti = _repo.GetAll();

            foreach (Supporto supporto in elencoSupporti)
            {
                if (supporto is not null)
                {
                    SupportoDTO supportoDTOtemp = new SupportoDTO()
                    {
                        codi = supporto.Codice,
                        tito = supporto.Titolo,
                        anno = supporto.Anno,
                        disp = supporto.Disponibilita,
                        tipo = supporto.Tipo
                    };

                    risultato.Add(supportoDTOtemp);
                }
            }

            return risultato;
        }

        public bool EliminaSupporto(string varCod)
        {
            bool ris = false;

            Supporto? supportoDaEliminare = _repo.GetByCodice(varCod);
            if (supportoDaEliminare is not null)
                ris = _repo.Delete(supportoDaEliminare.Codice);

            return ris;
        }

    }
}
