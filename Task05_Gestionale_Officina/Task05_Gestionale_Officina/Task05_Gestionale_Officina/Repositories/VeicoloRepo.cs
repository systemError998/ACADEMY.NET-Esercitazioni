using Task05_Gestionale_Officina.Context;
using Task05_Gestionale_Officina.Models;

namespace Task05_Gestionale_Officina.Repositories
{

    public class VeicoloRepo : IRepoLettura<Veicolo>, IRepoScrittura<Veicolo>
    {
        private readonly OfficinaContext _context;
        public VeicoloRepo(OfficinaContext context) {
            _context = context;
        }


        public bool Create(Veicolo entity)
        {
            bool ris = false;

            try
            {
                _context.Veicoli.Add(entity);
                _context.SaveChanges(); 
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return ris;
        }

        public bool Delete(int cod)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Veicolo> GetAll()
        {
            return _context.Veicoli.ToList();
        }

        public Veicolo? GetByCodice(int cod)
        {
            throw new NotImplementedException();
        }

        public Veicolo? GetById(int id)
        {
            return _context.Veicoli.Find(id);
        }

        public bool Update(Veicolo entity)
        {
            throw new NotImplementedException();
        }
    }
}
