using MathService;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();
app.MapGet("/", () => "Hello CS420! Here is Fib(5)= "+ FactorialService.GetFactorial(5));



app.Run();
