namespace SoftwareStore
{
    using Caliburn.Micro;
    using SoftwareStore.Core.Contract;

    public class ShellViewModel : Screen
    {
        private IPackageRepository repo;

        public ShellViewModel(IPackageRepository repo)
        {
            this.repo = repo;
        }
        protected override void OnActivate()
        {
            base.OnActivate();
            this.DisplayName = "Bookstore";
        }

        public void AddSoftware(string description)
        {
            
        }
    }
}