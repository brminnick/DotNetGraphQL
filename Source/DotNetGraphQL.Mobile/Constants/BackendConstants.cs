using Xamarin.Forms;

namespace DotNetGraphQL.Mobile
{
    public static class BackendConstants
    {
#if DEBUG
        public static string GraphQLApiUrl { get; } = Device.RuntimePlatform is Device.Android ? "http://10.0.2.2:4000/" : "http://localhost:4000/";
#else
#error Missing GraphQL Api Url
        public static string GraphQLApiUrl { get; } = "";
#endif
    }
}
