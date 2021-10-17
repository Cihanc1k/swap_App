using AlGulumVerGulum.DAL.Abstract;
using AlGulumVerGulum.DAL.EntityFramework;
using AlGulumVerGulum.DOMAIN.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using Yazilim129.CORE.Data.EntityFramework;

namespace AlGulumVerGulum.DAL.Concrete
{
    public class PictureDal : EFRepository<AlGulumDbContext, Picture>, IPictureDal
    {
        public PictureDal(AlGulumDbContext context) : base(context)
        {
        }
    }
}
