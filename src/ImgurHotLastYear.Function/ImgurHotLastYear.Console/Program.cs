using ImgurHotLastYear.App;
using ImgurHotLastYear.App.Configuration;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;

var builder = Host.CreateApplicationBuilder();
builder.Configuration.AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);
builder.Configuration.AddJsonFile("appsettings.local.json", optional: true);

builder.Services.AddHotLastYear();
builder.Build();


await new Runner().FetchAndPostAsync();



