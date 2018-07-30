using System.ComponentModel.DataAnnotations;

namespace DotNetCoreWebApiProject.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}