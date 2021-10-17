using AlGulumVerGulum.DOMAIN.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using Yazilim129.CORE.Data.EntityFramework;

namespace AlGulumVerGulum.DAL.Abstract
{
    public interface ICategoryDal : IEFRepository<Category>
    {
        void GetCategoryOrderByNoticeCount();
    }
}
