using AlGulumVerGulum.DAL.Abstract;
using AlGulumVerGulum.DAL.EntityFramework;
using AlGulumVerGulum.DOMAIN.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using Yazilim129.CORE.Data.EntityFramework;

namespace AlGulumVerGulum.DAL.Concrete
{
    public class NoticeDal : EFRepository<AlGulumDbContext, Notice>, INoticeDal
    {
        public NoticeDal(AlGulumDbContext context) : base(context)
        {

        }
    }
}
