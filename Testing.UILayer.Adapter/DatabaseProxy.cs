
namespace Testing.UILayer.Adapter
{
    using System.ServiceModel;
    using System.ServiceModel.Description;

    using Bookstore.Core;
    using Bookstore.Services;

    public class DatabaseProxy : ClientBase<IBooksRepository>, IBooksRepository
    {
        public DatabaseProxy()
            : base(
                new ServiceEndpoint(
                    ContractDescription.GetContract(typeof(IBooksRepository)),
                    new NetNamedPipeBinding(),
                    new EndpointAddress(@"net.pipe://localhost/database")))
        {
            
        }

        public Bookshelf BookShelf { get; private set; }
    }
}