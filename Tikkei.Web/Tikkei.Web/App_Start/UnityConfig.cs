using System.Web.Mvc;
using Tikkei.Repository.Common;
using Tikkei.Repository.Repositories;
using Tikkei.Repository.Repository;
using Tikkei.Service.Services;
using Unity;
using Unity.Mvc5;

namespace Tikkei.Web
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();

            //injection UnitOfWork
            container.RegisterType<IUnitOfWork, UnitOfWork>();

            //injection Service
            container.RegisterType<IBillDetailService, BillDetailService>();
            container.RegisterType<IBillService, BillService>();
            container.RegisterType<ICategoryService, CategoryService>();
            container.RegisterType<IColorService, ColorService>();
            container.RegisterType<IImageService, ImageService>();
            container.RegisterType<IProductDetailService, ProductDetailService>();
            container.RegisterType<IProductService, ProductService>();
            container.RegisterType<ISizeService, SizeService>();
            container.RegisterType<IUserRoleService, UserRoleService>();
            container.RegisterType<IUserService, UserService>();

            //injection Respository
            container.RegisterType<IBillDetailRepository, BillDetailRepository>();
            container.RegisterType<IBillRepository, BillRepository>();
            container.RegisterType<ICategoryRepository, CategoryRepository>();
            container.RegisterType<IColorRepository, ColorRepository>();
            container.RegisterType<IImageRepository, ImageRepository>();
            container.RegisterType<IProductDetailRepository, ProductDetailRepository>();
            container.RegisterType<IProductRepository, ProductRepository>();
            container.RegisterType<ISizeRepository, SizeRepository>();
            container.RegisterType<IUserRepository, UserRepository>();
            container.RegisterType<IUserRoleRepository, UserRoleRepository>();

            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}