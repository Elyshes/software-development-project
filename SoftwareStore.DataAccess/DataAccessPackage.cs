namespace SoftwareStore.DataAccess
{
    using SimpleInjector;
    using SimpleInjector.Packaging;
    using SoftwareStore.Core.Contract;

    public class DataAccessPackage : IPackage
    {
        public void RegisterServices(Container container)
        {
            container.Register<IPackageRepository, SoftwarePackageSerializerStorage>();
        }
    }
}