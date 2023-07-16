using OpenQA.Selenium.Chrome;

namespace SeleniumTestProjecy
{
    public class UnitTest1: ChromeLauncher
    {
        [Fact]
        public void Test1()
        {
            _driver.Navigate().GoToUrl("https://www.google.com");

            Assert.Equal("Google", _driver.Title);

            //Assert.True(false);
        }

    }
}