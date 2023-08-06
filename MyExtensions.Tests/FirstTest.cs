namespace MyExtensions.Tests;

public class FirstTest
{
    [Fact]
    public void FirstTestWithoutParameter()
    {
        List<int> list = new List<int> { 1, 2, 3, 4, 5 };
        Assert.Equal(1, list.First());
    }

    [Fact]
    public void FirstTestWithEmptyCollection()
    {
        List<int> list = new List<int>();
        Assert.Throws<InvalidOperationException>(() => list.First());
        Assert.Throws<InvalidOperationException>(() => list.First(o => o >= 3));
    }

    [Fact]
    public void FirstTestWithParameter()
    {
        List<int> list = new List<int> { 1, 2, 3, 4, 5 };
        Assert.Equal(3, list.First(o => o >= 3));
    }

    [Fact]
    public void FirstTestWithWrongParameter()
    {
        List<int> list = new List<int> { 1, 2, 3, 4, 5 };
        Assert.Throws<InvalidOperationException>(() => list.First(o => o >= 6));
    }
}