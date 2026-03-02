using KataName.Controllers;

namespace KataName.Tests;

public class KataNameControllerTests
{
    [Test]
    public void Should_Return_Result_When_Size_Is_3()
    {
        var controller = new KataNameController();
        var result = controller.Index(3);

        var lines = result.Split("\n");
        Assert.Multiple(() =>
        {
            Assert.That(lines.Length, Is.EqualTo(3));
            // TODO: Add your assertions here
        });
    }
}
