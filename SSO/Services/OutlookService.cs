//using Microsoft.Graph.Models;
//using Microsoft.Identity.Client;
//using Microsoft.Graph;
//using Microsoft.Graph.Auth;

//namespace SSO.Services;

//public class OutlookService
//{
//    private readonly GraphServiceClient _graphClient;

//    public OutlookService(IConfiguration configuration)
//    {
//        string clientId = configuration["MicrosoftClientId"];
//        string clientSecret = configuration["MicrosoftSecretId"];
//        string[] scopes = new string[] { "https://graph.microsoft.com/.default" };

//        IConfidentialClientApplication confidentialClientApplication = ConfidentialClientApplicationBuilder
//            .Create(clientId)
//            .WithClientSecret(clientSecret)
//            .Build();

//        ClientCredentialProvider authProvider = new ClientCredentialProvider(confidentialClientApplication, scopes);

//        _graphClient = new GraphServiceClient(authProvider);
//    }

//    public async Task<IEnumerable<Message>> GetEmailsAsync()
//    {
//        try
//        {
//            var messages = await _graphClient.Me.Messages.Request().GetAsync();
//            return messages;
//        }
//        catch (ServiceException ex)
//        {
//            // Handle errors
//            throw;
//        }
//    }
//}
