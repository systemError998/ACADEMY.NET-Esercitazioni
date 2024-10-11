using REST_05_EF_Videoteche_Ref.Models;

namespace REST_05_EF_Videoteche_Ref.Repos
{
    public class SupportoRepo : IRepo<Supporto>
    {
        private readonly BlockbusterContext _context;

        public SupportoRepo(BlockbusterContext context)
        {
            _context = context;
        }

        public bool Create(Supporto entity)
        {
            bool risultato = false;
            try
            {
                _context.Supporti.Add(entity);
                _context.SaveChanges();

                risultato = true;
            } catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            return risultato;
        }

        public bool Delete(string varCodice)
        {
            bool risultato = false;
            try
            {
                Supporto suppdaEliminare = _context.Supporti.Single(s => s.Codice == varCodice);
                _context.Supporti.Remove(suppdaEliminare);
                _context.SaveChanges(); //per salvare le modifiche al database
                risultato = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return risultato;
        }

        public Supporto? Get(int id)
        {
            return _context.Supporti.Find(id);
        }

        public Supporto? GetByCodice(string cod)
        {
            return _context.Supporti.FirstOrDefault(supporto => supporto.Codice == cod);
        }

        public IEnumerable<Supporto> GetAll()
        {
            return _context.Supporti.ToList();
        }

        public bool Update(Supporto entity)
        {
            throw new NotImplementedException();
        }
    }
}
