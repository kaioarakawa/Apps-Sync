using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;

public class ChatHub : Hub
{
    public async Task SendMessage(string source, string message)
    {
        await Clients.All.SendAsync("ReceiveMessage", source, message);
    }
}
