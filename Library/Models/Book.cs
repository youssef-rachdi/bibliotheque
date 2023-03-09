using System.ComponentModel;

namespace WebBooks.Models
{
    public class Book
    {
        public string Id { get; set; }

        [DisplayName("Book Name")]
        public string? BookTitle { get; set; }

        [DisplayName("Book Description")]
        public string BookDescription { get; set; }

        [DisplayName("Book Image")]
        public string BookImage { get; set; }

        [DisplayName("Category")]
        public int CategoryId { get; set; }

        public virtual BookCategory BookCategory { get; set; }
    }
}