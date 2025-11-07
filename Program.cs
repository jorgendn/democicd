var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

app.UseHttpsRedirection();

app.MapGet("/test", () => new
    {
        opening_phrase = "Hello", 
        second_phrase = "Is it me you're looking for",
        third_phrase = "I can see it in your eyes"
    });

app.Run();