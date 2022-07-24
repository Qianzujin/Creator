using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace Creator.Pages;

public class Index_Tests : CreatorWebTestBase
{
    [Fact]
    public async Task Welcome_Page()
    {
        var response = await GetResponseAsStringAsync("/");
        response.ShouldNotBeNull();
    }
}
