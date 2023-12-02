using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace WebBooks.Models
{
    public class Category
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Category")]
        public string? CategoryName { get; set; }

        [Required]
        [Display(Name = "description")]
        public string? CatregoryDescription { get; set; }

        //public ICollection<Book> book { get; set; }
    }
}
