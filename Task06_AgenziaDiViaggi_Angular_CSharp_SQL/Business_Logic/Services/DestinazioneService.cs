using Business_Logic.Models;
using Business_Logic.Repos;

namespace Business_Logic.Services
{
    public class DestinazioneService : IService<Destinazione>
    {
        private readonly DestinazioneRepo _repo;

        public DestinazioneService(DestinazioneRepo repo) {
            _repo = repo;
        }

        public Destinazione? Cerca(string varCod)
        {
            throw new NotImplementedException();
        }

        public List<Destinazione> Lista()
        {
            List<Destinazione> destinazioniTrovate = new List<Destinazione>();
            IEnumerable<Destinazione> elencoDestinazioni = _repo.GetAll();

            foreach (Destinazione dest in elencoDestinazioni) {
                if (dest is not null) { 

                    destinazioniTrovate.Add(dest);
                }
            }

            return destinazioniTrovate;

        }
    }
}
