using Business_Logic.Context;
using Business_Logic.Models;

namespace Business_Logic.Repos
{
    public class RecensioneRepo : IRepo<Recensione>
    {
        private readonly LaPerlaNeraContext _laPerlaNeraContext;

        public RecensioneRepo(LaPerlaNeraContext laPerlaNeraContext) {
            _laPerlaNeraContext = laPerlaNeraContext;
        }

        public bool Create(Recensione entity)
        {
            throw new NotImplementedException();
        }

        public bool Delete(string codice)
        {
            throw new NotImplementedException();
        }

        public Recensione? Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Recensione> GetAll()
        {
            return _laPerlaNeraContext.Recensioni.ToList();
        }

        public bool Update(Recensione entity)
        {
            throw new NotImplementedException();
        }
    }
}
