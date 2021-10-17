using AlGulumVerGulum.BLL.Abstract;
using AlGulumVerGulum.DAL.Abstract;
using AlGulumVerGulum.DOMAIN.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using Yazilim129.CORE.Model;

namespace AlGulumVerGulum.BLL.Concrete
{
    public class PictureManager : IPictureService
    {
        private readonly IPictureDal _pictureDal;

        public PictureManager(IPictureDal pictureDal)
        {
            _pictureDal = pictureDal;
        }

        public ResultModel<Picture> Create(Picture entity)
        {
            return _pictureDal.Create(entity);
        }

        public ResultModel Delete(Picture entity)
        {
            return _pictureDal.Delete(entity);
        }

        public ResultModel<Picture> Get(Expression<Func<Picture, bool>> filter, params string[] includeList)
        {
            return _pictureDal.Get(filter, includeList);
        }

        public ResultModel<List<Picture>> GetList(Expression<Func<Picture, bool>> filter = null, bool isDesc = true, Expression<Func<Picture, object>> orderRule = null, params string[] includeList)
        {
            return _pictureDal.GetList(filter, isDesc, orderRule, includeList);
        }

        public ResultModel<Picture> Update(Picture entity)
        {
            return _pictureDal.Update(entity);
        }
    }
}
