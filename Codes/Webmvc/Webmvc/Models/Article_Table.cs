using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Webmvc.Models
{
    public class Article_Table
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

        public int UserId { get; set; }
        [ForeignKey("UserId")]
        public virtual User_Table UserName { get; set; }
        [Required]
       
        public int CategoryId { get; set; }
        [ForeignKey("CategoryId")]
        public virtual Category_Table Name { get; set; }
    }
}
