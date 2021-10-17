using AlGulumVerGulum.DAL.Abstract;
using AlGulumVerGulum.DAL.EntityFramework;
using AlGulumVerGulum.DOMAIN.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Yazilim129.CORE.Data.EntityFramework;

namespace AlGulumVerGulum.DAL.Concrete
{
    public class UserDal : EFRepository<AlGulumDbContext,AppUser>,IUserDal
    {
        public UserDal(AlGulumDbContext context) : base(context)
        {
        }

        public bool UserExists(string email)
        {
            return ctx.Users.Any(x => x.Email == email);
        }
    }
}
