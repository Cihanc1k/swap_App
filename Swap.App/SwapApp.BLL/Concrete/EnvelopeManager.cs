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
    public class EnvelopeManager : IEnvelopeService
    {
        private readonly IEnvelopeDal _envelopeDal;

        public EnvelopeManager(IEnvelopeDal envelopeDal)
        {
            _envelopeDal = envelopeDal;
        }

        public ResultModel<Envelope> Create(Envelope entity)
        {
            return _envelopeDal.Create(entity);
        }

        public ResultModel Delete(Envelope entity)
        {
            return _envelopeDal.Delete(entity);
        }

        public ResultModel<Envelope> Get(Expression<Func<Envelope, bool>> filter, params string[] includeList)
        {
            return _envelopeDal.Get(filter, includeList);
        }

        public ResultModel<List<Envelope>> GetList(Expression<Func<Envelope, bool>> filter = null, bool isDesc = true, Expression<Func<Envelope, object>> orderRule = null, params string[] includeList)
        {
            return _envelopeDal.GetList(filter, isDesc, orderRule, includeList);
        }

        public ResultModel<Envelope> Update(Envelope entity)
        {
            return _envelopeDal.Update(entity);
        }
    }
}
