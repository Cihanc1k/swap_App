using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace AlGulumVerGulum.DTO.UserDtos
{
    public class UserLoginDto
    { // DATA ANNOTIATION

        [Required(ErrorMessage ="Email alanı boş geçilemez")]
        [Display(Name ="E-posta")]
        [EmailAddress(ErrorMessage ="Lütfen geçerli bir e-posta adresi giriniz")]
        public string Email { get; set; }
        [Display(Name ="Şifre")]
        [Required(ErrorMessage ="Şifre alanı boş geçilemez")]
        public string Password { get; set; }
        [Display(Name ="Beni hatırla")]
        public bool Rememberme { get; set; }
    }
}
