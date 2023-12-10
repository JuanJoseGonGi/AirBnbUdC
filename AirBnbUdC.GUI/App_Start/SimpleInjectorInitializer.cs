[assembly: WebActivator.PostApplicationStartMethod(typeof(AirBnbUdC.GUI.App_Start.SimpleInjectorInitializer), "Initialize")]

namespace AirBnbUdC.GUI.App_Start
{
    using System.Reflection;
    using System.Web.Mvc;
    using AirbnbUdc.Repository.Contracts.Contracts.Parameters;
    using AirbnbUdc.Repository.Implementation.Implementation.Parameters;
    using SimpleInjector;
    using SimpleInjector.Integration.Web;
    using SimpleInjector.Integration.Web.Mvc;
    
    public static class SimpleInjectorInitializer
    {
        /// <summary>Initialize the container and register it as MVC3 Dependency Resolver.</summary>
        public static void Initialize()
        {
            var container = new Container();
            container.Options.DefaultScopedLifestyle = new WebRequestLifestyle();
            
            InitializeContainer(container);

            container.RegisterMvcControllers(Assembly.GetExecutingAssembly());
            
            container.Verify();
            
            DependencyResolver.SetResolver(new SimpleInjectorDependencyResolver(container));
        }
     
        private static void InitializeContainer(Container container)
        {


            //container.Register<ICityRepository, CityImplementationRepository>(Lifestyle.Scoped);
            //container.Register<ICountryRepository, CountryImplementationRepository>(Lifestyle.Scoped);
            container.Register<ICustomerRepository, CustomerImplementationRepository>(Lifestyle.Scoped);
            //container.Register<IFeedbackRepository, FeedbackImplementationRepository>(Lifestyle.Scoped);
            //container.Register<IMultimediaTypeRepository, MultimediaTypeImplementationRepository>(Lifestyle.Scoped);
            //container.Register<IPropertyRepository, PropertyImplementationRepository>(Lifestyle.Scoped);
            //container.Register<IPropertyMultimediaRepository, PropertyMultimediaImplementationRepository>(Lifestyle.Scoped);
            //container.Register<IPropertyOwnerRepository, PropertyOwnerImplementationRepository>(Lifestyle.Scoped);
            //container.Register<IReservationRepository, ReservationImplementationRepository>(Lifestyle.Scoped);

            // For instance:
            // container.Register<IUserRepository, SqlUserRepository>(Lifestyle.Scoped);

            //container.Register<IAirBnbUdC.BLL.IUsuarioLogic, AirBnbUdC.BLL.UsuarioLogic>(Lifestyle.Scoped);
        }
    }
}