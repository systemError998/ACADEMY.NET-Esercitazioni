using System.Linq;
using Task05_Gestionale_Officina.Context;
using Task05_Gestionale_Officina.Models;

namespace Task05_Gestionale_Officina.Repositories
{
    public class ClienteRepo : IRepoLettura<Cliente>, IRepoScrittura<Cliente>
    {

        private readonly OfficinaContext _context; //readonly così non posso modificare il contesto

        //iniezione della dipendenza context
        public ClienteRepo(OfficinaContext context) { 
            _context = context;
        }
        public bool Create(Cliente clt)
        {
            bool ris = false;

            try
            {
                //andiamo a prendere nel context il dbset su cui stiamo lavorando
                _context.Clienti.Add(clt);
                _context.SaveChanges(); //vanno sempre salvate le modifiche quando modifichiamo il db

                ris= true;  
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

        public IEnumerable<Cliente> GetAll()
        {
            return _context.Clienti.ToList();
            //il tolist ritorna una List<> ma essendo il tipo di ritorno IEnumerable in binding dinamico diventerà una lista
        }

        public Cliente? GetByCodice(string cod)
        {
            return _context.Clienti.FirstOrDefault(c => c.CodCliente == cod);
        }

        public Cliente? GetById(int id)
        {
            return _context.Clienti.Find(id);
            // SAME: return _context.Clienti.FirstOrDefault(c => c.ClienteID == id);
        }

        public bool Update(Cliente entity)
        {
            throw new NotImplementedException();
        }
    }
}
