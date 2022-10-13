namespace WebApplication_11october.Models
{
    public class OperationServices : ISingletonService, ITransientService, IScopedService
    {
        Guid id;
        Random r  = new Random();
        int no;
        public OperationServices()
        {
            id = Guid.NewGuid();
            no = r.Next(1200);
        }

        public int generaterandomnumber()
        {
            return no;
        }

        public Guid GetOperationID()
        {
            //throw new NotImplementedException();
            return id;
        }

        
    }
}
