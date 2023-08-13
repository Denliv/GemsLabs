namespace MyExtensions.Tests;

public class AnyTest
{
    [Fact]
    public void AnyTestWithoutParameter()
    {
        List<int> list = new List<int> { 1, 2, 3, 4, 5 };
        Assert.True(list.Any());
    }
    
    [Fact]
    public void AnyTestWithParameter()
    {
        List<int> list = new List<int> { 1, 2, 3, 4, 5 };
        Assert.True(list.Any(o => o >= 3));
    }
    
    [Fact]
    public void AnyTestWithEmptyCollection()
    {
        Assert.False(new List<int>().Any());
        Assert.False(new List<int>().Any(o => o >= 3));
    }
    
    [Fact]
    public void AnyTestWithWrongParameter()
    {
        List<int> list = new List<int> { 1, 2, 3, 4, 5 };
        Assert.False(list.Any(o => o >= 6));
    }
}