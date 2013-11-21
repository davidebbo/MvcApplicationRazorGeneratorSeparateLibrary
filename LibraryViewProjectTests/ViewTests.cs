using System;
using HtmlAgilityPack;
using LibraryViewProject.Views.Home;
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
            var view = new Index();

            // Set up the data that needs to be access by the view
            view.ViewBag.Message = message;

            // Render it as a string
            string output = view.Render();

            // Verify that it looks correct
            Assert.IsTrue(output.Contains(message));
        }

        [TestClass]
        public class UnitTest1
        {
            [TestMethod]
            public void TestRenderAsHtml()
            {
                const string message = "Some unit test message!";

                // Instantiate the view directly
                var view = new Index();

                // Set up the data that needs to be access by the view
                view.ViewBag.Message = message;

                // Render it in an HtmlDocument
                var doc = view.RenderAsHtml();

                // Verify that it looks correct
                HtmlNode node = doc.DocumentNode.Element("h2");
                Assert.AreEqual(message, node.InnerHtml.Trim());
            }
        }
    }
}
