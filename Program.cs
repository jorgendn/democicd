var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

app.UseHttpsRedirection();

app.MapGet("/test", () => new { opening_phrase = "Hello", rest_of_message = "Is it me you're looking for" });

app.Run();