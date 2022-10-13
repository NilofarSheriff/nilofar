using System.ComponentModel.DataAnnotations;

namespace _11OCTOBERAssignments.Models
{
    public class ProductModel : ITransient,ISingleton
    {
        [Required()]
        public int Proid { get; set; }
        [MaxLength(10, ErrorMessage = "Too Lengthy Name")]
        [MinLength(3, ErrorMessage = "Too Short Name")]
        [Required()]
        public string? ProdName { get; set; }
        [Required()]
        public int Price { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime MfgDate { get; set; }

        public int GetProductId()
        {
            Random r= new Random(); 
            Proid = r.Next(10);
            return Proid;
            
        }

        public int GetDetailsPro()
        {
            Proid = 1;
            return Proid;
        }

       
    }
}
