namespace Testing;

public class UnitTest1
{
    [Fact]
    public void TestListConstructor_CreatesListWithDefaultCapacity()
    {
        // Arrange & Act
        var list = new Utils.List<int>();

        // Assert
        Assert.NotNull(list);
    }

    [Fact]
    public void TestListConstructor_CreatesListForStringType()
    {
        // Arrange & Act
        var list = new Utils.List<string>();

        // Assert
        Assert.NotNull(list);
    }

    [Fact]
    public void TestListConstructor_CreatesListForCustomType()
    {
        // Arrange & Act
        var list = new Utils.List<object>();

        // Assert
        Assert.NotNull(list);
    }
}
