namespace Assignment2.Tests;
using static Assignment2.Delegates;

public class DelegatesTests
{   
    //Warning! If one unit test fails, this will also fail
    [Fact]
    public void ReverseOrder_Should_Succeed()
    {
        var stringWriter = new StringWriter();
        Console.SetOut(stringWriter);

        ReverseOrder("Tom");
        Assert.Equal("moT\r\n", stringWriter.ToString());
    }
    [Fact]
    public void ProductOfTwoDoubles_Should_Be_6_25()
    {
        //Arrange
        var expected = 6.25;
        //Act
        var output = Assignment2.Delegates.ProductOfTwoDoubles(2.5,2.5);
        //Assert
        output.Should().Be(expected);
    }   

    [Fact]
    public void ProductOfTwoDoubles_Should_Not_Be_6_25()
    {
        //Arrange
        var expected = 6.25;
        //Act
        var output = Assignment2.Delegates.ProductOfTwoDoubles(2.5,10.5);
        //Assert
        output.Should().NotBe(expected);
    }
    [Fact]
    public void NumericallyEqual_Should_Be_True()
    {
        //Arrange
        var expected = true;
        //Act
        var output = Assignment2.Delegates.NumericallyEqual(42, "0042");
        //Assert
        output.Should().Be(expected);
    }

    [Fact]
    public void NumericallyEqual_Should_Be_False()
    {
        //Arrange
        var expected = true;
        //Act
        var output = Assignment2.Delegates.NumericallyEqual(422, "0042");
        //Assert
        output.Should().NotBe(expected);
    }
}
