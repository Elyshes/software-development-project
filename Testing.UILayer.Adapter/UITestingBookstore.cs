namespace Testing.UILayer.Adapter
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Threading;

    using Bookstore.Core;

    using KS.Core.Testing.UserInterfaceAutomation.Application;
    using KS.Core.Testing.UserInterfaceAutomation.Controls;

    using Testing.Contract;

    internal class UITestingBookstore : IBookstore
    {
        private TestApplication app;

        public UITestingBookstore()
        {
            var applicationPath = AppDomain.CurrentDomain.BaseDirectory;
            var pathElements = applicationPath.Split(Path.DirectorySeparatorChar);
            var configuration = pathElements[pathElements.Length - 1];
            this.app = new TestApplication(
                Path.Combine(applicationPath, @"..\..\..\", @"Bookstore\bin\" + configuration + @"\Bookstore.exe"), "Bookstore", this.ApplicationShutdown);
        }

        public void Initialize()
        {
            this.app.Start();
            Thread.Sleep(1000);
        }

        public void AddBook(Book book)
        {
            var title = new EditControl("Title");
            title.Enter(book.Title);

            var isbn = new EditControl("Isbn");
            isbn.Enter(book.Isbn);

            var add = new ClickControl("AddBook");
            add.ClickLeft();

            var status = new EditControl("Status").GetValue();
            if (status == "ISBN already exists!")
            {
                throw new IsbnAlreadyExistsException();
            }

            if(status == "Title with different ISBN already exists!")
            {
                throw new TitleAlreadyExistsWithDifferentIsbnException();
            }

            var clear = new ClickControl("New");
            clear.ClickLeft();
        }

        public IEnumerable<Book> Books
        {
            get
            {
                var books = new SelectionControl("Books");

                return books.GetItemsTextsContent().Select(book => new Book(book[0], book[1]));
            }
        }

        private void ApplicationShutdown()
        {
            var shutdown = new ClickControl("Close");
            shutdown.ClickLeft();
        }
    }
}