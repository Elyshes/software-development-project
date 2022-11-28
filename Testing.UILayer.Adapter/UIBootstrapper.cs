namespace Testing.UILayer.Adapter
{
    using Testing.Contract;

    public class UIBootstrapper : IBoostrapper, IInializer
    {
        private UITestingBookstore bookstore = new UITestingBookstore();

        public IBookstore Bookstore
        {
            get
            {
                return this.bookstore;
            }
        }

        public IBoostrapper Initalize()
        {
            this.bookstore.Initialize();

            return this;
        }
    }
}