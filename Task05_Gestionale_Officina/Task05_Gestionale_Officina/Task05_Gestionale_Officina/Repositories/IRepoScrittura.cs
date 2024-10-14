namespace Task05_Gestionale_Officina.Repositories
{
    public interface IRepoScrittura<T>
    {
        bool Create(T entity);
        bool Delete(int cod);
        bool Update(T entity);
    }
}
