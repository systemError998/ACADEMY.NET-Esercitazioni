using Business_Logic.Context;
using Business_Logic.Models;

namespace Business_Logic.Repos
{
    public class PacchettoVacanzaRepo : IRepo<PacchettoVacanza>
    {
        private readonly LaPerlaNeraContext _laPerlaNeraContext;
        public PacchettoVacanzaRepo(LaPerlaNeraContext context)
        {
            _laPerlaNeraContext = context;
        }

        public bool Create(PacchettoVacanza entity)
        {
            throw new NotImplementedException();
        }

        public bool Delete(string codice)
        {
            throw new NotImplementedException();
        }

        public PacchettoVacanza? Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<PacchettoVacanza> GetAll()
        {
            return _laPerlaNeraContext.Pacchetti.ToList();
        }

        public bool Update(PacchettoVacanza entity)
        {
            throw new NotImplementedException();
        }
    }
}
