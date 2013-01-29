using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RazorGenerator.Testing;

namespace LibraryViewProjectTests
{
    [TestClass]
    public class ViewTests
    {
        [TestMethod]
        public void TestIndexView()
        {
            const string message = "Some unit test message!";

            // Instantiate the view directly
            var view = new LibraryViewProject.Views.Home.Index();

            // Set up the data that needs to be access by the view
            view.ViewBag.Message = message;

            // Render it in an HtmlDocument
            string output = view.Render();

            // Verify that it looks correct
            Assert.IsTrue(output.Contains(message));
        }
    }
}
