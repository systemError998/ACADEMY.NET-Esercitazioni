namespace Task05_Gestionale_Officina.Repositories
{
    public interface IRepoLettura<T>
    {
        IEnumerable<T> GetAll();
        T? GetById(int id);
        // T? GetByCodice(int cod); NO NELL'INTERFACCIA?

    }
}
