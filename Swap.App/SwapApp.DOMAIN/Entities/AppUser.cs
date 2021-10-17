using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;
using Yazilim129.CORE.Model;

namespace AlGulumVerGulum.DOMAIN.Entities
{
    public class AppUser : BaseEntity
    {
        public string Name { get; set; }
        public string Surname { get; set; }

        // TODO : Unique Email
        public string Email { get; set; }
        public string PhoneNumber { get; set; }

        // TODO : Password hash
        public string Password { get; set; }
        public string City { get; set; }
        public string District { get; set; }
        public bool Gender { get; set; }

        // TODO: Email Confirmation
        public bool EmailConfirmed { get; set; }
        public List<Notice> Notices { get; set; }
    }
}

// Hesabım - Cari Hesap - Öğrenciler - Personel İşlemleri - Eğitim İşlemleri - Harcamalar
