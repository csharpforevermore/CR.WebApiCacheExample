using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CR.Surpass.WebAPI1;
using CR.Surpass.WebAPI1.Controllers;

namespace CR.Surpass.WebAPI1.Tests.Controllers
{
	[TestClass]
	public class HomeControllerTest
	{
		[TestMethod]
		public void Index()
		{
			// Arrange
			HomeController controller = new HomeController();

			// Act
			ViewResult result = controller.Index() as ViewResult;

			// Assert
			Assert.IsNotNull(result);
			Assert.AreEqual("Home Page", result.ViewBag.Title);
		}
	}
}
