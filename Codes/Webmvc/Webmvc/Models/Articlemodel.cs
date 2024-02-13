using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Webmvc.Models
{
    public class Articlemodel
    {
        [Key]
        public int ArticleId { get; set; }
        [Required]
        public String Title { get; set; }
        [Required]
        public String Content { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime PublishedDate { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime LastModifiedDate { get; set; }
        [Required]

        public int AuthorId { get; set; }
        public virtual User_Table UserName { get; set; }
        [Required]
        public int CategoryId { get; set; }
        public virtual Category_Table Name { get; set; }
    }
}
