using Autofac;
using Autofac.Extras.DynamicProxy;
using Business.Abstract;
using Business.Concrete;
using Castle.DynamicProxy;
using Core.Utilities.Interceptors;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;

namespace Business.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<JobPositionManager>().As<IJobPositionService>();
            builder.RegisterType<EfJobPositionDal>().As<IJobPositionDal>();

            builder.RegisterType<ApplicantManager>().As<IApplicantService>();
            builder.RegisterType<EfApplicantDal>().As<IApplicantDal>();

            builder.RegisterType<EmployerManager>().As<IEmployerService>();
            builder.RegisterType<EfEmployerDal>().As<IEmployerDal>();

            builder.RegisterType<JobAdvertManager>().As<IJobAdvertService>();
            builder.RegisterType<EfJobAdvertDal>().As<IJobAdvertDal>();

            var assembly = System.Reflection.Assembly.GetExecutingAssembly();

            builder.RegisterAssemblyTypes(assembly).AsImplementedInterfaces()
                .EnableInterfaceInterceptors(new ProxyGenerationOptions()
                {
                    Selector = new AspectInterceptorSelector()
                }).SingleInstance();
        }
    }
}
