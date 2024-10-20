using Business_Logic.Models;
using Business_Logic.Models.DTO;
using Business_Logic.Repos;

namespace Business_Logic.Services
{
    public class DestinazioneService : IService<DestinazioneDTO>
    {
        private readonly DestinazioneRepo _repo;

        public DestinazioneService(DestinazioneRepo repo) {
            _repo = repo;
        }

        public List<DestinazioneDTO> Lista()
        {
            List<DestinazioneDTO> destinazioniDTO = new List<DestinazioneDTO>();
            IEnumerable<Destinazione> elencoDestinazioni = _repo.GetAll();

            foreach (Destinazione dest in elencoDestinazioni) {
                if (dest is not null) {
                    DestinazioneDTO destDTO = new DestinazioneDTO()
                    {
                        cod = dest.DestinazioneCOD,
                        nom = dest.Nome,
                        des = dest.Descrizione,
                        pae = dest.Paese,
                        img = dest.Copertina
                    };
                    destinazioniDTO.Add(destDTO);
                }
            }

            return destinazioniDTO;

        }

        DestinazioneDTO? IService<DestinazioneDTO>.Cerca(string varCod)
        {
            throw new NotImplementedException();
        }
    }
}
