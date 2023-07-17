using System.Threading.Tasks;
using LibraryApp.Models.TokenAuth;
using LibraryApp.Web.Controllers;
using Shouldly;
using Xunit;

namespace LibraryApp.Web.Tests.Controllers
{
    public class HomeController_Tests: LibraryAppWebTestBase
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