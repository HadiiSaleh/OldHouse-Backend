using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace OldHouse_Backend.Models
{
    public class Relative
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(256, ErrorMessage = "Maximum length for first name is {1}")]
        [RegularExpression("^[A-Za-z]+$")]
        public string FullName { get; set; }

        [Required]
        [DataType(DataType.PhoneNumber)]
        [StringLength(256, ErrorMessage = "Maximum length for phone number is {1}")]
        [RegularExpression("[+][0-9]{3} [0-9]{8}")]
        public string Phone { get; set; }

        [Required]
        [StringLength(256, ErrorMessage = "Maximum length for relative relation number is {1}")]
        public string Relation { get; set; }

        public List<UsersRelatives> UsersRelatives { get; set; }
    }
}
