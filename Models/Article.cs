using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ReviewApp.Models{

    public class Article{

        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string article_id { get; set; }

        [Required]
        public string title { get; set; }

        public string content { get; set; }


        [Required]
        [ForeignKey("user")]
        public string user_id { get; set; }
        public User user { get; set; }
    }
}