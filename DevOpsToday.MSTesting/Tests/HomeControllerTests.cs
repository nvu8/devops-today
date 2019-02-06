using DevOpsToday.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace DevOpsToday.MSTesting.Tests
{
  [TestClass]
  public static class HomeControllerTests
  {
    [TestMethod]
    public static void Test_IndexAction()
    {
      var sut = new HomeController();

      Assert.IsNotNull(sut.Index());
    }
    [TestMethod]
    public static void Test_PrivacyAction()
    {
      var sut = new HomeController();

      Assert.IsNotNull(sut.Privacy());
    }
  }
}