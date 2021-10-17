using AlGulumVerGulum.DOMAIN.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using Yazilim129.CORE.Data.EntityFramework;

namespace AlGulumVerGulum.DAL.Abstract
{
    public interface IUserDal : IEFRepository<AppUser>
    {
        bool UserExists(string email);
    }
}
