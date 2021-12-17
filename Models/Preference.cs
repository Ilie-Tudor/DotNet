using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ReviewApp.Models{

    public class Preference{

        [Required]
        [ForeignKey("user")]
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string user_id { get; set; }
        public User user { get; set; }

        [DefaultValue(false)]
        public bool darkmode { get; set; }

        public bool gdpr_acceptance { get; set; }

    }
}