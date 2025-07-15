
using FizzBuzz.Domains;

namespace FizzBuzz.Controllers;

public class FizzBuzzController
{
    public string Index(int size)
    {
        var fizzBuzzBuilder = new FizzBuzzBuilder(size);
        
        fizzBuzzBuilder.Build();
        
        return fizzBuzzBuilder.Result();
    }
}