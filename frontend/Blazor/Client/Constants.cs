using Microsoft.AspNetCore.SignalR.Client;

namespace Blazor.Client
{
    public class Constants
    {
        public static HubConnection connection = new HubConnectionBuilder()
            .WithUrl("https://localhost:7291/test")
            .Build();

        public static bool connectionFlag = false;
    }
}
