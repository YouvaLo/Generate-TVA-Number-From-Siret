using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using VerifySiretGenerateTVA;
using VerifySiretGenerateTVA.services;
using VerifySiretGenerateTVA.Utils;

var builder = Host.CreateApplicationBuilder(args);

builder.Services.AddScoped<IGenerateTVANumber, GenerateTVANumber>();
builder.Services.AddScoped<IVerifySiretNumber, VerifySiretNumber>();
builder.Services.AddScoped<Start>();

var host = builder.Build();
var app = host.Services.GetRequiredService<Start>();

app.Run();
