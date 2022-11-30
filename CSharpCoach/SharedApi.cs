namespace CSharpCoach
{
    public static class SharedApi
    {
        public static ApiClient.ApiClient SharedClient { get; private set; }

        public static ApiClient.ApiClient Build(string baseUrl, string authentication = null)
        {
            SharedClient = new ApiClient.ApiClient(baseUrl, authentication);;

            return SharedClient;
        }
    }
}