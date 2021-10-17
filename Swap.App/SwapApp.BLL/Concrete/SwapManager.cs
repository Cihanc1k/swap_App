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
    public class SwapManager : ISwapService
    {
        private readonly ISwapDal _swapDal;

        public SwapManager(ISwapDal swapDal)
        {
            _swapDal = swapDal;
        }

        public ResultModel<Swap> Create(Swap entity)
        {
            return _swapDal.Create(entity);
        }

        public ResultModel Delete(Swap entity)
        {
            return _swapDal.Delete(entity);
        }

        public ResultModel<Swap> Get(Expression<Func<Swap, bool>> filter, params string[] includeList)
        {
            return _swapDal.Get(filter, includeList);
        }

        public ResultModel<List<Swap>> GetList(Expression<Func<Swap, bool>> filter = null, bool isDesc = true, Expression<Func<Swap, object>> orderRule = null, params string[] includeList)
        {
            return _swapDal.GetList(filter, isDesc, orderRule, includeList);
        }

        public ResultModel<Swap> Update(Swap entity)
        {
            return _swapDal.Update(entity);
        }
    }
}
