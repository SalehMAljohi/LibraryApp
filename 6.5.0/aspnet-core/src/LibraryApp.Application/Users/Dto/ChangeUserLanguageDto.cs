using System.ComponentModel.DataAnnotations;

namespace LibraryApp.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}