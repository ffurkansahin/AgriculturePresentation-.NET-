using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace AgriculturePresentation.Models
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage = "Lütfen kullanıcı adınızı giriniz!")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Lütfen şifreyi giriniz!")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Lütfen mail giriniz!")]
        public string Mail { get; set; }

        [Required(ErrorMessage = "Lütfen şifrenizi tekrar giriniz!")]
        [Compare("Password",ErrorMessage ="Şifreler uyumlu değil lütfen kontrol ediniz!")]
        public string PasswordConfirm { get; set; }

    }
}
