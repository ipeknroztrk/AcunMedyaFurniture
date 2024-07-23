using System.ComponentModel.DataAnnotations;

namespace AcunMedyaFurniter.Models
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage = "Email gereklidir.")]
        [EmailAddress(ErrorMessage = "Geçerli bir email adresi giriniz.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Kullanıcı adı gereklidir.")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Ad gereklidir.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Soyad gereklidir.")]
        public string Surname { get; set; }

        [Required(ErrorMessage = "Şifre gereklidir.")]
        [DataType(DataType.Password)]
        [MinLength(6, ErrorMessage = "Şifre en az 6 karakter uzunluğunda olmalıdır.")]
        public string Password { get; set; }
    }
}
