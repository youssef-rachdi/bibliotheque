using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace WebBooks.Models
{
    public class BookCategory
    {
        public string Id { get; set; }
        [Required]
        [Display(Name = "Category")]
        public string CategoryName { get; set; }
        [Required]
        [Display(Name = "description")]
        public string CatregoryDescription { get; set; }

        public virtual ICollection<Book> book { get; set; }
    }
}
