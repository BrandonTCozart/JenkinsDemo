namespace JenkinsDemo.Tests;

public class UnitTest1
{
    [Fact]
    public void Add_ReturnsCorrectSum()
    {
        int result = Calculator.Add(2, 2);

        Assert.Equal(4, result);
    }
}
