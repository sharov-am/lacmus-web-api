using System.ComponentModel.DataAnnotations;

namespace lacmus.WebApp.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}