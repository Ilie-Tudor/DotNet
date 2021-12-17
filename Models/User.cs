using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ReviewApp.Models{

    public class User{

        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string user_id { get ; set;}

        [Required]
        public string email{ get; set;}

        [Required]
        public string password{ get; set;}

        [ForeignKey("userCategory")]
        [Required]
        public string userCategery_id { get; set;}

        public virtual UserCategory userCategory { get; set;}

        public Profile profile {get; set; }
        
        public Preference preference {get; set; }

        public ICollection<Article> Articles { get; set; }
        
    }

}