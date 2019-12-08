namespace HomeworkVariantOneExcel
{
    using System.IO;
    using System.Threading.Tasks;
    using Microsoft.Graph;
    using Microsoft.Graph.Auth;
    using Microsoft.Identity.Client;

    public class AccessFilesOnOneDrive
    {
        public static Stream GetFile()
        {
            return GetFileFromOneDriveAsync().Result;
        }

        private static async Task<Stream> GetFile()
        {
            IPublicClientApplication publicClientApplication = PublicClientApplicationBuilder
                        .Create("2vs23b94-s8gj-4eff-f9fn-bdfvd34aw0xw")
                        .WithRedirectUri("http://localhost")
                        .Build();

            var authentificationProvider = new InteractiveAuthenticationProvider(publicClientApplication, new[] { "Files.read" });

            GraphServiceClient graphClient = new GraphServiceClient(authentificationProvider);

            var stream = await graphClient.Me.Drive.Items["385737!87775463263}"].Content
                .Request()
                .GetAsync();

            return stream;
        }
    }
}