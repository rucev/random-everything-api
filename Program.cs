using System.Text.Json;
var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

var random = new Random();

static List<string> LoadList(string fileName) => JsonSerializer.Deserialize<List<string>>(File.ReadAllText($"Data/{fileName}"))!;

var names = LoadList("names.json");
var colors = LoadList("colors.json");
var countries = LoadList("countries.json");
var months = LoadList("months.json");

app.MapGet("/random/name", () =>
{
  return Results.Ok(names[random.Next(names.Count)]);
});

app.MapGet("/random/color", () =>
{
  return Results.Ok(colors[random.Next(colors.Count)]);
});

app.MapGet("/random/country", () =>
{
  return Results.Ok(countries[random.Next(countries.Count)]);
});

app.MapGet("/random/number", () =>
{
  return Results.Ok(random.Next(1, 100));
});

app.MapGet("/random/month", () =>
{
  return Results.Ok(months[random.Next(months.Count)]);
});

app.Run();
