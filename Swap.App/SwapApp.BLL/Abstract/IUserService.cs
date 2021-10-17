using AlGulumVerGulum.DOMAIN.Entities;
using AlGulumVerGulum.DTO.UserDtos;
using System;
using System.Collections.Generic;
using System.Text;
using Yazilim129.CORE.Model;

namespace AlGulumVerGulum.BLL.Abstract
{
    public interface IUserService : IGenericService<AppUser>
    {
        bool UserExists(string email);

        ResultModel<AppUser> Login(UserLoginDto dto);
    }
}
