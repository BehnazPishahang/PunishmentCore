namespace Anu.DataAccess
{
    public interface IDependencyResolver
    {
        object Resolve(System.Type type);

        T Resolve<T>(System.Type type);
    }
}