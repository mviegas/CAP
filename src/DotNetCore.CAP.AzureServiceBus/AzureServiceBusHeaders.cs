namespace DotNetCore.CAP.AzureServiceBus
{
    public static class AzureServiceBusHeaders
    {
        public const string SessionId = "cap-session-id";

        /// <summary>
        /// Specifies a destination Topic where the Message will be sent to, if there are Multiple topics configured.
        /// </summary>
        public const string DestinationTopicPath = "cap-destination-topic-path";
    }
}
