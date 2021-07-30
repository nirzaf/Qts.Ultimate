using System.ComponentModel.DataAnnotations;

namespace Qts.Ultimate.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}