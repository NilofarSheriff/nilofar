namespace _11OCTOBERAssignments.Models
{
    public class BookModel:IScoped
    {
       
        public int BookNo { get; set; }
        public string? BookName { get; set; }

        public int Price { get; set; }

        public string? Author { get; set; }

        public string? Category { get; set; }

        public int GetBookNo()
        {
            //throw new NotImplementedException();
            Random random = new Random();
            int bookNo = random.Next(100);
            return bookNo;
        }
    }
}
