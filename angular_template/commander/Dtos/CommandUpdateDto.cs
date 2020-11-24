using System.ComponentModel.DataAnnotations;

namespace Commander.Dtos
{

    /* 
        Identitcal to the other dtos so far...
     */
    public class CommandUpdateDto
    {
        [Required]
        [MaxLength(250)]
        public string HowTo { get; set; }

        [Required]
        public string Line { get; set; }

        [Required]
        public string Platform { get; set; }

    }
}