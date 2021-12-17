using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ReviewApp.Models{

    public class ArticleCategory{

        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string articleCategory_id { get; set; }

        [Required]
        public string tag  { get; set; }

    }
}