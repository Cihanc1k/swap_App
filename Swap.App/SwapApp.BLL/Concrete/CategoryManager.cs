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
    public class CategoryManager : ICategoryService
    {
        private readonly ICategoryDal _categoryDal;
        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }
        public ResultModel<Category> Create(Category entity)
        {
            return _categoryDal.Create(entity);
        }

        public ResultModel Delete(Category entity)
        {
            return _categoryDal.Delete(entity);
        }

        public ResultModel<Category> Get(Expression<Func<Category, bool>> filter, params string[] includeList)
        {
            return _categoryDal.Get(filter, includeList);
        }

        public ResultModel<List<Category>> GetList(Expression<Func<Category, bool>> filter = null, bool isDesc = true, Expression<Func<Category, object>> orderRule = null, params string[] includeList)
        {
            return _categoryDal.GetList(filter, isDesc, orderRule, includeList);
        }

        public ResultModel<Category> Update(Category entity)
        {
            return _categoryDal.Update(entity);
        }
    }
}
