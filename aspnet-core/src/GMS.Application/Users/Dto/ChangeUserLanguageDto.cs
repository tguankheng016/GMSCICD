using System.ComponentModel.DataAnnotations;

namespace GMS.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}