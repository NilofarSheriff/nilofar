namespace WebApplication_11october.Models
{
    public interface ITransientService
    {
        Guid GetOperationID();
        int generaterandomnumber();

    }

    public interface IScopedService
    {
        Guid GetOperationID();
        int generaterandomnumber();
    }
    public interface ISingletonService
    {
        Guid GetOperationID();
        int generaterandomnumber();

    }
}
