using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            builder.RegisterType<AddressManager>().As<IAddressService>().SingleInstance();
            builder.RegisterType<EfAddressDal>().As<IAddressDal>().SingleInstance();

            builder.RegisterType<BasketDetailManager>().As<IBasketDetailService>();
            builder.RegisterType<EfBasketDetailDal>().As<IBasketDetailDal>();

            builder.RegisterType<BasketManager>().As<IBasketService>();
            builder.RegisterType<EfBasketDal>().As<IBasketDal>();

            builder.RegisterType<CategoryManager>().As<ICategoryService>().SingleInstance();
            builder.RegisterType<EfCategoryDal>().As<ICategoryDal>().SingleInstance();

            builder.RegisterType<CategorySubManager>().As<ICategorySubService>().SingleInstance();
            builder.RegisterType<EfCategorySubDal>().As<ICategorySubDal>().SingleInstance();

            builder.RegisterType<CityManager>().As<ICityService>().SingleInstance();
            builder.RegisterType<EfCityDal>().As<ICityDal>().SingleInstance();

            builder.RegisterType<CreditCartManager>().As<ICreditCartService>();
            builder.RegisterType<EfCreditCartDal>().As<ICreditCartDal>();

            builder.RegisterType<CustomerManager>().As<ICustomerService>();
            builder.RegisterType<EfCustomerDal>().As<ICustomerDal>();

            builder.RegisterType<DistrictManager>().As<IDistrictService>().SingleInstance();
            builder.RegisterType<EfDistrictDal>().As<IDistrictDal>().SingleInstance();

            builder.RegisterType<ProductDetailManager>().As<IProductDetailService>().SingleInstance();
            builder.RegisterType<EfProductDetailDal>().As<IProductDetailDal>().SingleInstance();

            builder.RegisterType<ProductManager>().As<IProductService>().SingleInstance();
            builder.RegisterType<EfProductDal>().As<IProductDal>().SingleInstance();


            builder.RegisterType<AddressDetailManager>().As<IAddressDetailService>();
            builder.RegisterType<EfAddressDetailDal>().As<IAddressDetailDal>();


            builder.RegisterType<FavoriteManager>().As<IFavoriteService>();
            builder.RegisterType<EfFavoriteDal>().As<IFavoriteDal>();


            builder.RegisterType<OrderManager>().As<IOrderService>();
            builder.RegisterType<EfOrderDal>().As<IOrderDal>();


            builder.RegisterType<CampaignDetailManager>().As<ICampaignDetailService>();
            builder.RegisterType<EfCampaignDetailDal>().As<ICampaignDetailDal>();


            builder.RegisterType<CampaignManager>().As<ICampaignService>();
            builder.RegisterType<EfCampaignDal>().As<ICampaignDal>();


            builder.RegisterType<PaymentManager>().As<IPaymentService>();
            builder.RegisterType<EfPaymentDal>().As<IPaymentDal>();


            var assembly = System.Reflection.Assembly.GetExecutingAssembly();
            builder.RegisterAssemblyTypes(assembly).AsImplementedInterfaces()
                .EnableInterfaceInterceptors(new ProxyGenerationOptions()
                {
                    Selector = new AspectInterceptorSelector()
                }).SingleInstance();
        }
    }
}
