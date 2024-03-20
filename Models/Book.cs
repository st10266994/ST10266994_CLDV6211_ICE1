using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace ReadingRecords.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string? ISBN { get; set; }
        public string? Title { get; set; }
        public string? Author { get; set; }
        [Display(Name = "Publication Date")]
        [DataType(DataType.Date)]
        public DateTime PublicationDate { get; set; }
        public string? Genre { get; set; }
      
      
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }
       

    }
}
