
using FizzBuzz.Domains;
using Microsoft.AspNetCore.Mvc;

namespace FizzBuzz.Controllers;

[ApiController]
[Route("api/[controller]")]
public class FizzBuzzController : ControllerBase
{
    public string Index(int size)
    {
        var fizzBuzzBuilder = new FizzBuzzBuilder(size);
        
        fizzBuzzBuilder.Build();
        
        return fizzBuzzBuilder.Result();
    }
}