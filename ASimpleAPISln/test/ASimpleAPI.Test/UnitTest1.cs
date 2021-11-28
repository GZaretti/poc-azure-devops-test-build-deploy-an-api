using Xunit;
using ASimpleAPI.Controllers;
namespace ASimpleAPI.Test;

public class UnitTest1
{

    WeatherForecastController controller = new WeatherForecastController();
    [Fact]
    public void GetRetrunsMy()
    {
        int id = 1;
        var returnValue = controller.Get(id);
        Assert.Equal("Weather id : " + id.ToString(), returnValue.Value);
    }

    [Fact]
    public void Test1()
    {

    }
}