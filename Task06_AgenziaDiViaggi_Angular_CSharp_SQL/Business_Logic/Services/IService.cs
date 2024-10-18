namespace Business_Logic.Services
{
    public interface IService<T>
    {
        List<T> Lista();
        T? Cerca(string varCod);
    }
}
