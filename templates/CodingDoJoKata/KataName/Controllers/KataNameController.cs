using KataName.Domains;
using Microsoft.AspNetCore.Mvc;

namespace KataName.Controllers;

[ApiController]
[Route("api/[controller]")]
public class KataNameController : ControllerBase
{
    public string Index(int size)
    {
        var builder = new KataNameBuilder(size);

        builder.Build();

        return builder.Result();
    }
}
