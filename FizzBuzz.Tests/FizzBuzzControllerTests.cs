using FizzBuzz.Controllers;

namespace FizzBuzz.Tests;

public class FizzBuzzControllerTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Fizz_When_Divided_By_Three()
    {
        var controller = new FizzBuzzController();
        var result = controller.Index(3);

        Assert.That(result, Is.EqualTo("1\r\n2\r\nFizz"));
    }
}