using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using VerifySiretGenerateTVA;
using VerifySiretGenerateTVA.services;
using VerifySiretGenerateTVA.Utils;

var builder = Host.CreateApplicationBuilder(args);

//Registers a Scoped service to generate VAT numbers.
builder.Services.AddScoped<IGenerateTVANumber, GenerateTVANumber>();

//Registers a Scoped service to verify Siret number.
builder.Services.AddScoped<IVerifySiretNumber, VerifySiretNumber>();

//Registers a Scoped service to start the application.
builder.Services.AddScoped<Start>();

var host = builder.Build();
var app = host.Services.GetRequiredService<Start>();

app.Run();
