namespace MyExtensions.Tests;

public class WhereTest
{
    [Fact]
    public void WhereTestNonEmptyCollection()
    {
        List<int> list = new List<int> { 1, 2, 3, 4, 5 };
        Assert.Equal(new List<int>(), list.Where(o => o >= 6));
        Assert.Equal(new List<int> { 3, 4, 5 }, list.Where(o => o >= 3));
    }

    [Fact]
    public void WhereTestEmptyCollection()
    {
        Assert.Equal(new List<int>(), new List<int>().Where(o => o >= 3));
    }
}