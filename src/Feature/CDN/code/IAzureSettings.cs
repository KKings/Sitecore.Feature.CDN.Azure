namespace Sitecore.Feature.CDN
{
    public interface IAzureSettings
    {
        string Authority { get; set; }
        string ClientId { get; set; }
        string ClientSecret { get; set; }
        string EndpointName { get; set; }
        string ProfileName { get; set; }
        string ResourceGroupName { get; set; }
        string SubscriptionId { get; set; }
    }
}