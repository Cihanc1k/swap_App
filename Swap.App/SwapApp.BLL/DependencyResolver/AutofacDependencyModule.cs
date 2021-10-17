using AlGulumVerGulum.BLL.Abstract;
using AlGulumVerGulum.BLL.Concrete;
using AlGulumVerGulum.DAL.Abstract;
using AlGulumVerGulum.DAL.Concrete;
using AlGulumVerGulum.DAL.EntityFramework;
using Autofac;
using System;
using System.Collections.Generic;
using System.Text;

namespace AlGulumVerGulum.BLL.DependencyResolver
{
    public class AutofacDependencyModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            // DAL
            builder.RegisterType<CategoryDal>().As<ICategoryDal>();
            builder.RegisterType<PictureDal>().As<IPictureDal>();
            builder.RegisterType<NoticeDal>().As<INoticeDal>();
            builder.RegisterType<SwapDal>().As<ISwapDal>();
            builder.RegisterType<UserDal>().As<IUserDal>();


            // BLL
            builder.RegisterType<CategoryManager>().As<ICategoryService>();
            builder.RegisterType<PictureManager>().As<IPictureService>();
            builder.RegisterType<NoticeManager>().As<INoticeService>();
            builder.RegisterType<SwapManager>().As<ISwapService>();
            builder.RegisterType<UserManager>().As<IUserService>();
        }
    }
}
