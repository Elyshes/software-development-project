namespace Testing.ServiceLayer.Adapter
{

    using SimpleInjector;

    using Testing.Contract;

    public class ServiceBootstrapper : IBoostrapper, IInializer
    {
        private Container container;

        public IBoostrapper Initalize()
        {
            return this;
        }
    }
}