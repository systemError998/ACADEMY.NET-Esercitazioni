namespace REST_05_EF_Videoteche_Ref.Services
{
    public interface IService<T>
    {
        List<T> Lista();

        T? Cerca(string varCod);
    }
}
