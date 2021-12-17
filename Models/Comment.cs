using System.ComponentModel.DataAnnotations;

namespace ReviewApp.Models{

    public class Comment{

        public string user_id { get; set; }
        public string article_id { get; set; }

        [Required]
        public string text { get; set; }
    }
}