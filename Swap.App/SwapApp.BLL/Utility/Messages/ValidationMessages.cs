using System;
using System.Collections.Generic;
using System.Text;

namespace AlGulumVerGulum.BLL.Utility.Messages
{
    public class ValidationMessages
    {
        // Tek tip validasyon mesajları
        public static string EmailExist = "Bu e-posta zaten kullanılıyor";
        public static string LoginFailed = "Hatalı kullanıcı adı veya şifre";
        public static string EmailNotValid = "Geçersiz bir e-posta girdiniz";
        public static string TooShort = "Girilen değer çok kısa";
    }
}
