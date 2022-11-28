namespace SoftwareStore
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Reflection;

    using Caliburn.Micro;

    using SimpleInjector;

    public class ApplicationBootstrapper : Bootstrapper<ShellViewModel>
    {
        private readonly Container container = new Container();

        /// <summary>
        /// Override to configure the framework and setup your IoC <see cref="container"/>.
        /// </summary>
        protected override void Configure()
        {
            this.container.Register<IWindowManager, WindowManager>();
            this.container.Register<IEventAggregator, EventAggregator>();
            this.container.Register<ShellViewModel, ShellViewModel>();
            this.container.Register<ShellView, ShellView>();

            var path = AppDomain.CurrentDomain.BaseDirectory;
            var assemblies = Directory.GetFiles(path, "*.dll").Select(Assembly.LoadFile).ToList();
            this.container.RegisterPackages(assemblies);
        }

        /// <summary>
        /// Override <see langword="this" /> to provide an IoC specific
        /// implementation.
        /// </summary>
        /// <param name="service">The service to locate.</param>
        /// <param name="key">The key to locate.</param>
        /// <returns>
        /// The located service.
        /// </returns>
        protected override object GetInstance(Type service, string key)
        {
            return this.container.GetInstance(service);
        }

        /// <summary>
        /// Override <see langword="this" /> to provide an IoC specific
        /// implementation
        /// </summary>
        /// <param name="service">The service to locate.</param>
        /// <returns>
        /// The located services.
        /// </returns>
        protected override IEnumerable<object> GetAllInstances(Type service)
        {
            return this.container.GetAllInstances(service);
        }

        /// <summary>
        /// Override to tell the framework where to find assemblies to inspect for views, etc.
        /// </summary>
        /// <returns>
        /// A list of assemblies to inspect.
        /// </returns>
        protected override IEnumerable<Assembly> SelectAssemblies()
        {
            return AppDomain.CurrentDomain.GetAssemblies();
        }
    }
}