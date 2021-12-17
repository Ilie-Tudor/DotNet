using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ReviewApp.Models{

    public class UserCategory{

        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string userCategory_id { get; set; }

        [Required]
        public string role { get; set; }

        [Required]
        public string aditionalInfo_id { get; set; }

        public virtual ICollection<User> Users { get; set; }
    }
}