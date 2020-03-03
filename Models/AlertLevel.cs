using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace OldHouse_Backend.Models
{
    public class AlertLevel
    {
        [Key]
        public int Id { get; set; }

        [StringLength(256, ErrorMessage = "Maximum length for level is {1}")]
        public string Level { get; set; }

        [StringLength(256, ErrorMessage = "Maximum length for color is {1}")]
        public string Color { get; set; }

        public List<Alert> Alerts { get; set; }
    }
}
