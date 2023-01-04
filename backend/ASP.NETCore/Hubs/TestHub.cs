using Microsoft.AspNetCore.SignalR;

namespace ASP.NETCore.Hubs
{
	public class TestHub : Hub
	{
		public async Task SendTestData()
		{
			string testMessage = "Test data is delivered";

			await Clients.Caller.SendAsync("GetTestData", testMessage);
		}
	}
}
