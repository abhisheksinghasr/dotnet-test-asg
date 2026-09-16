using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Hosting;
using Microsoft.AspNetCore.Http;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello from Docker.");

app.MapGet("/health", () => Results.Ok("Healthy"));

app.Run("http://0.0.0.0:8080");