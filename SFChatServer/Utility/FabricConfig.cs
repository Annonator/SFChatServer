namespace Utility
{
    public class FabricConfig
    {
        public static readonly string ServiceUri = "fabric:/SFChatServer";

        /// <summary>
        ///     Service Name has to match the name in the ServiceManifest.xml
        /// </summary>
        public static readonly string GatewayServiceType = "GatewayType";

        /// <summary>
        ///     Service Name has to match the name in the ServiceManifest.xml
        /// </summary>
        public static readonly string ChatServiceType = "ChatServiceType";
    }
}