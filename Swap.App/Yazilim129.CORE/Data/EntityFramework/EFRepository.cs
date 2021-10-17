using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using Yazilim129.CORE.Model;
using Yazilim129.CORE.Utility;

namespace Yazilim129.CORE.Data.EntityFramework
{
    public class EFRepository<TContext, T> : IEFRepository<T>
        where T : class, IBaseEntity
        where TContext : DbContext
    {
        protected TContext ctx;
        private DbSet<T> dbSet;
        public EFRepository(TContext context)
        {
            ctx = context;
            dbSet = ctx.Set<T>();
        }
        public ResultModel<T> Create(T entity)
        {
            ResultModel<T> resultModel = null;

            try
            {
                var result = dbSet.Add(entity);

                if (result.State == EntityState.Added && ctx.SaveChanges() > 0)
                    resultModel = new ResultModel<T>(result.Entity, ResultType.Success, "Ekleme işlemi başarılı");
                else
                    resultModel = new ResultModel<T>(null, ResultType.Warning, "Ekleme işlemi başarısız");
            }
            catch (Exception ex)
            {
                resultModel = new ResultModel<T>(null, ResultType.Error, "Hata oluştu: " + ex.Message);
                resultModel.Data = null;
                resultModel.Type = ResultType.Error;
                resultModel.Message = "Hata oluştu: " + ex.ToInnestException().Message;
            }

            return resultModel;
        }

        public ResultModel Delete(T entity)
        {
            ResultModel model = null;
            try
            {
                var removeResult = dbSet.Remove(entity);
                if (removeResult.State == EntityState.Deleted && ctx.SaveChanges() > 0)
                    model = new ResultModel(ResultType.Success, "Silme işlemi başarılı");
                else
                    model = new ResultModel(ResultType.Warning, "Silme işlemi başarısız");

            }
            catch (Exception ex)
            {
                model = new ResultModel(ResultType.Error, "Hata oluştu: " + ex.ToInnestException().Message);
            }
            return model;
        }

        public ResultModel<T> Get(Expression<Func<T, bool>> filter, params string[] includeList)
        {
            ResultModel<T> resultModel = null;

            try
            {
                IQueryable<T> resultData = dbSet;
                if (includeList != null)
                {
                    foreach (var includeItem in includeList)
                        resultData = resultData.Include(includeItem);
                }

                var data = resultData.FirstOrDefault();

                if (data != null)
                    resultModel = new ResultModel<T>(data, ResultType.Success, "Başarılı");
                else
                    resultModel = new ResultModel<T>(null, ResultType.Warning, "Veri bulunamadı");
            }
            catch (Exception ex)
            {
                resultModel = new ResultModel<T>(null, ResultType.Error, "Hata oluştu: " + ex.ToInnestException().Message);
            }

            return resultModel;
        }

        public ResultModel<List<T>> GetList(Expression<Func<T, bool>> filter = null, bool isDesc = true, Expression<Func<T, object>> orderRule = null, params string[] includeList)
        {
            ResultModel<List<T>> resultModel = null;

            try
            {
                IQueryable<T> query = dbSet;

                if (filter != null)
                {
                    query = query.Where(filter);
                }

                if (orderRule != null)
                {
                    if (isDesc)
                        query = query.OrderByDescending(orderRule);
                    else
                        query = query.OrderBy(orderRule);
                }

                if (includeList != null)
                {
                    foreach (var includeItem in includeList)
                    {
                        query = query.Include(includeItem);
                    }
                }

                var data = query.ToList();

                if (data!=null && data.Count>0)
                {
                    resultModel = new ResultModel<List<T>>(data, ResultType.Success, "Başarılı");
                }
                else
                {
                    resultModel = new ResultModel<List<T>>(null, ResultType.Warning, "Veri bulunamadı");
                }
            }
            catch (Exception ex)
            {
                resultModel = new ResultModel<List<T>>(null, ResultType.Error, "Hata oluştu: " + ex.ToInnestException().Message);
            }


            return resultModel;
        }

        public ResultModel<T> Update(T entity)
        {
            ResultModel<T> resultModel = null;
            try
            {
                var result = dbSet.Update(entity);
                if (result.State == EntityState.Modified && ctx.SaveChanges() > 0)
                {
                    resultModel = new ResultModel<T>(result.Entity, ResultType.Success, "Güncelleme başarılı");
                }
                else
                {
                    resultModel = new ResultModel<T>(null, ResultType.Warning, "Güncelleme başarısız");
                }
            }
            catch (Exception ex)
            {
                resultModel = new ResultModel<T>(null, ResultType.Error, "Hata oluştu: " + ex.ToInnestException().Message);
            }
            return resultModel;
        }
    }
}
