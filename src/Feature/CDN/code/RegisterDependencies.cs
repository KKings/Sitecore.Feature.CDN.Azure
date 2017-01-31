namespace Sitecore.Feature.CDN
{
    using Abstractions;
    using DependencyInjection;
    using Foundation.CDN;
    using Microsoft.Extensions.DependencyInjection;
    using Microsoft.Extensions.DependencyInjection.Extensions;

    public class RegisterDependencies : IServicesConfigurator
    {
        public void Configure(IServiceCollection serviceCollection)
        {
            serviceCollection.AddSingleton<IAzureSettings>(
                (provider) => provider.GetService<BaseFactory>().CreateObject("azure", true) as IAzureSettings);
            
            serviceCollection.Replace(ServiceDescriptor.Singleton<IDeliveryService, AzureDeliveryService>());
        }
    }
}