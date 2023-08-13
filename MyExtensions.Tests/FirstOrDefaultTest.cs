namespace MyExtensions.Tests;

public class FirstOrDefaultTest
{
    [Fact]
    public void FirstOrDefaultTestWithoutParameter()
    {
        List<int> list = new List<int> { 1, 2, 3, 4, 5 };
        Assert.Equal(1, list.FirstOrDefault());
    }

    [Fact]
    public void FirstOrDefaultTestWithEmptyCollection()
    {
        Assert.Equal(0, new List<int>().FirstOrDefault());
        Assert.Equal(0, new List<int>().FirstOrDefault(o => o >= 3));
    }

    [Fact]
    public void FirstOrDefaultTestWithParameter()
    {
        List<int> list = new List<int> { 1, 2, 3, 4, 5 };
        Assert.Equal(3, list.FirstOrDefault(o => o >= 3));
    }

    [Fact]
    public void FirstOrDefaultTestWithWrongParameter()
    {
        List<int> list = new List<int> { 1, 2, 3, 4, 5 };
        Assert.Equal(0, list.FirstOrDefault(o => o >= 6));
    }
}