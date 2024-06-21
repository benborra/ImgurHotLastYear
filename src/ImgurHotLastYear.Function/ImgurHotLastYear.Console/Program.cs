using ImgurHotLastYear.App;
using ImgurHotLastYear.App.Configuration;
using ImgurHotLastYear.App.Models.App;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

var builder = Host.CreateApplicationBuilder();
builder.Configuration.AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);
builder.Configuration.AddJsonFile("appsettings.local.json", optional: true);

builder.Services.Configure<ImgurConfig>(builder.Configuration.GetSection("Imgur"));
builder.Services.AddHotLastYear();
var host = builder.Build();


var runner = host.Services.GetRequiredService<IRunner>();
await runner.FetchAndPostAsync();

