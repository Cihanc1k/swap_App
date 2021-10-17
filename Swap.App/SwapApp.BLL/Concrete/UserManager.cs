using AlGulumVerGulum.BLL.Abstract;
using AlGulumVerGulum.BLL.Utility.Messages;
using AlGulumVerGulum.DAL.Abstract;
using AlGulumVerGulum.DOMAIN.Entities;
using AlGulumVerGulum.DTO.UserDtos;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using Yazilim129.CORE.Model;

namespace AlGulumVerGulum.BLL.Concrete
{
    public class UserManager : IUserService
    {
        private readonly IUserDal _userDal;

        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }

        public ResultModel<AppUser> Create(AppUser entity)
        {
            return _userDal.Create(entity);
        }

        public ResultModel Delete(AppUser entity)
        {
            return _userDal.Delete(entity);
        }

        public ResultModel<AppUser> Get(Expression<Func<AppUser, bool>> filter, params string[] includeList)
        {
            return _userDal.Get(filter, includeList);
        }

        public ResultModel<List<AppUser>> GetList(Expression<Func<AppUser, bool>> filter = null, bool isDesc = true, Expression<Func<AppUser, object>> orderRule = null, params string[] includeList)
        {
            return _userDal.GetList(filter, isDesc, orderRule, includeList);
        }

        public ResultModel<AppUser> Login(UserLoginDto dto)
        {
            var result = _userDal.Get(x => x.Email == dto.Email && x.Password == dto.Password);

            if (result.Data==null)
            {
                return new ResultModel<AppUser>(null, ResultType.Error, ValidationMessages.LoginFailed);
            }
            return result;

        }

        public ResultModel<AppUser> Update(AppUser entity)
        {
            return _userDal.Update(entity);
        }

        public bool UserExists(string email)
        {
            return _userDal.UserExists(email);
        }
    }
}
