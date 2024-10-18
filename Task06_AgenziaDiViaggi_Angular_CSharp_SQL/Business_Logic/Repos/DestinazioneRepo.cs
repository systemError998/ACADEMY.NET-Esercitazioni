using Business_Logic.Context;
using Business_Logic.Models;

namespace Business_Logic.Repos
{
    public class DestinazioneRepo : IRepo<Destinazione>
    {
        private readonly LaPerlaNeraContext _laPerlaNeraContext;
        public DestinazioneRepo(LaPerlaNeraContext context) {
            _laPerlaNeraContext = context;
        }

        public bool Create(Destinazione entity)
        {
            throw new NotImplementedException();
        }

        public bool Delete(string codice)
        {
            throw new NotImplementedException();
        }

        public Destinazione? Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Destinazione> GetAll()
        {
            return _laPerlaNeraContext.Destinazioni.ToList();
        }

        public bool Update(Destinazione entity)
        {
            throw new NotImplementedException();
        }
    }
}
