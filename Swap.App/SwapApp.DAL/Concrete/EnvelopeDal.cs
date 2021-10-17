using AlGulumVerGulum.DAL.Abstract;
using AlGulumVerGulum.DAL.EntityFramework;
using AlGulumVerGulum.DOMAIN.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using Yazilim129.CORE.Data.EntityFramework;

namespace AlGulumVerGulum.DAL.Concrete
{
    public class EnvelopeDal : EFRepository<AlGulumDbContext, Envelope>, IEnvelopeDal
    {
        public EnvelopeDal(AlGulumDbContext context) : base(context)
        {
        }
    }
}
