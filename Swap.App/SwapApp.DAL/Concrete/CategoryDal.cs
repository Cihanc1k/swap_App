using AlGulumVerGulum.DAL.Abstract;
using AlGulumVerGulum.DAL.EntityFramework;
using AlGulumVerGulum.DOMAIN.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using Yazilim129.CORE.Data.EntityFramework;

namespace AlGulumVerGulum.DAL.Concrete
{
    public class CategoryDal : EFRepository<AlGulumDbContext,Category>,ICategoryDal
    {
        public CategoryDal(AlGulumDbContext ctx) : base(ctx)
        {

        }

        public void GetCategoryOrderByNoticeCount()
        {
            throw new NotImplementedException();
        }
    }
}
