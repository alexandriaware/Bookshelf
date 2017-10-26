using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Bookshelf.Models
{
    public class Book
    {
        [Key]
        public int ID { get; set; }
        [MinLength(2), MaxLength(50)] //Now our Title needs a minimum of two characters but not more than fifty.
        public string Title { get; set; }
        [Display(Name ="Date Published")]
        public DateTime PublishedDate { get; set; }
        [MaxLength(500)]
        public string Description { get; set; }
        public string ISBN { get; set; }

        [ForeignKey("Category"), Display(Name = "Genre")]
        public int CategoryID { get; set; }
        public virtual Category Category { get; set; }

    }
}