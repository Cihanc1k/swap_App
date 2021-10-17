using AlGulumVerGulum.DAL.Abstract;
using AlGulumVerGulum.DAL.EntityFramework;
using AlGulumVerGulum.DOMAIN.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using Yazilim129.CORE.Data.EntityFramework;

namespace AlGulumVerGulum.DAL.Concrete
{
    public class SwapDal:EFRepository<AlGulumDbContext,Swap>,ISwapDal
    {
        public SwapDal(AlGulumDbContext context):base(context)
        {

        }
    }
}
