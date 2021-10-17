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

    // GenericServiceWithDapper
    // .NETCORENtierProject
    // .NET CORE DI Container
    // WPF Stok Takip


    // CRUD - Create-Read-Update-Delete

    public class NoticeManager : INoticeService
    {
        private readonly INoticeDal _noticeDal;
        public NoticeManager(INoticeDal noticeDal)
        {
            _noticeDal = noticeDal;
        }
        public ResultModel<Notice> Create(Notice entity)
        {
            return _noticeDal.Create(entity);
        }

        public ResultModel Delete(Notice entity)
        {
            return _noticeDal.Delete(entity);
        }

        public ResultModel<Notice> Get(Expression<Func<Notice, bool>> filter, params string[] includeList)
        {
            return _noticeDal.Get(filter, includeList);
        }

        public ResultModel<List<Notice>> GetList(Expression<Func<Notice, bool>> filter = null, bool isDesc = true, Expression<Func<Notice, object>> orderRule = null, params string[] includeList)
        {
            return _noticeDal.GetList(filter, isDesc, orderRule, includeList);
        }

        public ResultModel<Notice> Update(Notice entity)
        {
            return _noticeDal.Update(entity);
        }
    }
}
