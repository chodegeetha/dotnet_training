using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Crud_mvc_withado1.Models
{
    public class Articlemodel
    {
        [Key]
        public int ArticleId { get; set; }

        [Required(ErrorMessage = "Title is required")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Content is required")]
        public string Content { get; set; }

        [Required(ErrorMessage = "Published Date is required")]
        public DateTime PublishedDate { get; set; }

        [Required(ErrorMessage = "Last Modified Date is required")]
        public DateTime LastModifiedDate { get; set; }
    }
}