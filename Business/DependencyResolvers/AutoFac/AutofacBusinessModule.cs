using Autofac;
using Business.Abstract;
using Castle.DynamicProxy;
using Core.Utilities.InterCeptors;
using Core.Utilities.Security.Jwt;
using DataAccess.Abstract;
using DataAccess.Concrete.EntitiyFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac.Extras.DynamicProxy;
using DataAccess.Concrete.EntityFramework;
using Core.Utilities.FileHelper;
using Business.Concrete;

namespace Business.DependencyResolvers.AutoFac
{
   public  class AutofacBusinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            //data tutmayan tip==instance
            builder.RegisterType<UserManager>().As<IUserService>().SingleInstance();
            builder.RegisterType<EfUserDal>().As<IUserDal>().SingleInstance();
            builder.RegisterType<EfFormDal>().As<IFormDal>().SingleInstance();
            builder.RegisterType<FormManager>().As<FormService>().SingleInstance();

            builder.RegisterType<AuthManager>().As<IAuthService>().SingleInstance();
            builder.RegisterType<JwtHelper>().As<ITokenHelper>().SingleInstance();
            builder.RegisterType<FormImageManager>().As<IFormImageService>().SingleInstance();
            builder.RegisterType<EfFormImageDal>().As<IFormImageDal>().SingleInstance();
            builder.RegisterType<FormStatusManager>().As<IFormStatusService>().SingleInstance();
            builder.RegisterType<EfFormStatusDal>().As<IFormStatusDal>().SingleInstance();
            builder.RegisterType<EFUserOpClaimDal>().As<IUserOpClaimDal>().SingleInstance();
            builder.RegisterType<UserOpManager>().As<IUserClaimService>().SingleInstance();

            builder.RegisterType<FileHelperManager>().As<IFileHelper>();
            var assembly = System.Reflection.Assembly.GetExecutingAssembly();

            builder.RegisterAssemblyTypes(assembly).AsImplementedInterfaces()
                .EnableInterfaceInterceptors(new ProxyGenerationOptions()
                {
                    Selector = new AspectInterceptorSelector()
                }).SingleInstance();

        }
    }
}
