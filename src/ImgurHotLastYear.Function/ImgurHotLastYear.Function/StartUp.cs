using ImgurHotLastYear.App;
using Microsoft.Azure.WebJobs;
using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;

namespace ImgurHotLastYear.Function;

public class StartUp
{
    [FunctionName("StartUp")]
    public async Task RunAsync([TimerTrigger("0 20 * * *")] TimerInfo myTimer, ILogger log)
    {
        log.LogInformation($"C# Timer trigger function executed at: {DateTime.Now}");

        await new Runner().FetchAndPostAsync();
    }
}
