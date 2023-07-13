using System.Threading.Tasks;
using GMS.Models.TokenAuth;
using GMS.Web.Controllers;
using Shouldly;
using Xunit;

namespace GMS.Web.Tests.Controllers
{
    public class HomeController_Tests: GMSWebTestBase
    {
        [Fact]
        public async Task Index_Test()
        {
            await AuthenticateAsync(null, new AuthenticateModel
            {
                UserNameOrEmailAddress = "admin",
                Password = "123qwe"
            });

            //Act
            var response = await GetResponseAsStringAsync(
                GetUrl<HomeController>(nameof(HomeController.Index))
            );

            //Assert
            response.ShouldNotBeNullOrEmpty();
        }
    }
}