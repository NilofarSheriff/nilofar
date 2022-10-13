namespace _11OCTOBERAssignments.Models
{
    public interface ITransient
    {
       int GetProductId();
    }

    public interface ISingleton
    {
        int GetDetailsPro();
    }

    public interface IScoped
    {

        int GetBookNo();
    }
}
