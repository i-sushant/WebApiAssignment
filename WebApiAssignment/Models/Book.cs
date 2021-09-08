using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiAssignment.Models
{
    [Table("Books")]
    public class Book
    {
        
        public int BookId { get; set; }
        
        public string BookName { get; set; }
        
        public string PublishedAt { get; set; }

        
        public int AuthorId { get; set; }
        
        public Author Author { get; set; }
    }
}
