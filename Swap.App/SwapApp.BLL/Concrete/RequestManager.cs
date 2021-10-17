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
    public class RequestManager : IRequestService
    {
        private readonly IRequestDal _requestDal;

        public RequestManager(IRequestDal requestDal)
        {
            _requestDal = requestDal;
        }

        public ResultModel<Request> Create(Request entity)
        {
            return _requestDal.Create(entity);
        }

        public ResultModel Delete(Request entity)
        {
            return _requestDal.Delete(entity);
        }

        public ResultModel<Request> Get(Expression<Func<Request, bool>> filter, params string[] includeList)
        {
            return _requestDal.Get(filter, includeList);
        }

        public ResultModel<List<Request>> GetList(Expression<Func<Request, bool>> filter = null, bool isDesc = true, Expression<Func<Request, object>> orderRule = null, params string[] includeList)
        {
            return _requestDal.GetList(filter,isDesc,orderRule,includeList);
        }

        public ResultModel<Request> Update(Request entity)
        {
            return _requestDal.Update(entity);
        }
    }
}
