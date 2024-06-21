using ImgurHotLastYear.App.Configuration;
using ImgurHotLastYear.App.Models.App;
using Microsoft.Azure.Functions.Extensions.DependencyInjection;
using Microsoft.Azure.WebJobs;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace ImgurHotLastYear.Function;

public class OnStartUp : FunctionsStartup
{
    public override void Configure(IFunctionsHostBuilder builder)
    {
        builder.Services.AddHotLastYear();

        builder.Services.AddOptions<ImgurConfig>()
            .Configure<IConfiguration>((settings, configuration) =>
            {
                configuration.GetSection("Imgur").Bind(settings);
            });
    }
}