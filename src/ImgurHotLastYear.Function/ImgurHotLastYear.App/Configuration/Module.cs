using Microsoft.Extensions.DependencyInjection;

namespace ImgurHotLastYear.App.Configuration;
public static class Module
{
    public static IServiceCollection AddHotLastYear(this IServiceCollection serviceDescriptors)
    {
        return serviceDescriptors;
    }
}
