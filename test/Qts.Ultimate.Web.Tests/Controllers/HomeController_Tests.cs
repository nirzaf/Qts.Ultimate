using System.Threading.Tasks;
using Qts.Ultimate.Models.TokenAuth;
using Qts.Ultimate.Web.Controllers;
using Shouldly;
using Xunit;

namespace Qts.Ultimate.Web.Tests.Controllers
{
    public class HomeController_Tests: UltimateWebTestBase
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