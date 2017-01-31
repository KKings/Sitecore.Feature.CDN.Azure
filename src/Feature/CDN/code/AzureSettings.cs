namespace Sitecore.Feature.CDN
{
    public class AzureSettings : IAzureSettings
    {
        /// <summary>
        /// Gets or sets the Client Id
        /// </summary>
        public string ClientId { get; set; }

        /// <summary>
        /// Gets or sets the Client Secret
        /// </summary>
        public string ClientSecret { get; set; }

        /// <summary>
        /// Gets or sets the Authority
        /// </summary>
        public string Authority { get; set; }

        /// <summary>
        /// Gets or sets the SubscriptionId
        /// </summary>
        public string SubscriptionId { get; set; }

        /// <summary>
        /// Gets or sets the Profile Name
        /// </summary>
        public string ProfileName { get; set; }

        /// <summary>
        /// Gets or sets the Cdn Endpoint Name
        /// </summary>
        public string EndpointName { get; set; }

        /// <summary>
        /// Gets or sets the Resource Group
        /// </summary>
        public string ResourceGroupName { get; set; }
    }
}