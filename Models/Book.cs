using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Raducu_Alexandru_Gabriel_Lab8.Models
{
    public class Book
    {
        public int ID { get; set; }

        [Display(Name = "Book Title")]
        public string Title { get; set; }
        public string Author { get; set; }

        [Column(TypeName = "decimal(6, 2)")]
        public decimal Price { get; set; }

        [DataType(DataType.Date)]
        public System.DateTime PublishingDate { get; set; }
        public int PublisherID { get; set; }
        public Publisher Publisher { get; set; } //navigation property
        public ICollection<BookCategory> BookCategories { get; set; }
    }
}
