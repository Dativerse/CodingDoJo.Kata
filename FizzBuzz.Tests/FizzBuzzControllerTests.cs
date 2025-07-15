using FizzBuzz.Controllers;

namespace FizzBuzz.Tests;

public class FizzBuzzControllerTests
{
    [Test]
    public void Fizz_When_5()
    {
        var controller = new FizzBuzzController();
        var result = controller.Index(3);

        var lines = result.Split("\n");
        Assert.Multiple(() =>
        {
            Assert.That(lines.Length, Is.EqualTo(3));
            Assert.That(lines.Last(), Is.EqualTo("Fizz"));
        });
    }
    
    [Test]
    public void Buzz_When_5()
    {
        var controller = new FizzBuzzController();
        var result = controller.Index(5);

        var lines = result.Split("\n");
        Assert.Multiple(() =>
        {
            Assert.That(lines.Length, Is.EqualTo(5));
            Assert.That(lines.Last(), Is.EqualTo("Buzz"));
        });
    }
    
    [Test]
    public void FizzBuzz_When_15()
    {
        var controller = new FizzBuzzController();
        var result = controller.Index(15);

        var lines = result.Split("\n");
        Assert.Multiple(() =>
        {
            Assert.That(lines.Length, Is.EqualTo(15));
            Assert.That(lines.Last(), Is.EqualTo("FizzBuzz"));
        });
    }
    
    [Test]
    public void Fizz_When_13()
    {
        var controller = new FizzBuzzController();
        var result = controller.Index(13);

        var lines = result.Split("\n");
        Assert.Multiple(() =>
        {
            Assert.That(lines.Length, Is.EqualTo(13));
            Assert.That(lines.Last(), Is.EqualTo("Fizz"));
        });
    }
    
    [Test]
    public void FizzBuzz_When_53()
    {
        var controller = new FizzBuzzController();
        var result = controller.Index(53);

        var lines = result.Split("\n");
        Assert.Multiple(() =>
        {
            Assert.That(lines.Length, Is.EqualTo(53));
            Assert.That(lines.Last(), Is.EqualTo("FizzBuzz"));
        });
    }
    
    [Test]
    public void FizzBuzz_When_35()
    {
        var controller = new FizzBuzzController();
        var result = controller.Index(35);

        var lines = result.Split("\n");
        Assert.Multiple(() =>
        {
            Assert.That(lines.Length, Is.EqualTo(35));
            Assert.That(lines.Last(), Is.EqualTo("FizzBuzzBuzz"));
        });
    }
}