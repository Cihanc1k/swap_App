using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using Yazilim129.CORE.Model;

namespace AlGulumVerGulum.BLL.Abstract
{
    public interface IGenericService<T>
    {
        ResultModel Delete(T entity);
        ResultModel<T> Create(T entity);
        ResultModel<T> Update(T entity);
        ResultModel<T> Get(Expression<Func<T, bool>> filter, params string[] includeList);
        ResultModel<List<T>> GetList(Expression<Func<T, bool>> filter = null, bool isDesc = true, Expression<Func<T, object>> orderRule = null, params string[] includeList);
    }
}
