using System.ComponentModel.DataAnnotations;

namespace Commander.Dtos
{
    public class CommandCreateDto
    {
        [Required]
        public string HowTo {get; set;}

        [Required]
        public string CommandLine {get; set;}
        
        [Required]
         public string Platform {get; set;}
    }
}