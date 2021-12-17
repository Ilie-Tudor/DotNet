using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ReviewApp.Models{

    public class Profile{

        [Required]
        [ForeignKey("user")]
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string user_id { get; set; }
        public User user { get; set; }

        [Required]
        public string displayName { get;  set; }

        [DefaultValue(0)]
        public int? age { get; set; }

    }
}