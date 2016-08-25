using System.Threading.Tasks;
using ActorBackend.Interfaces.Entities;
using Microsoft.AspNet.SignalR;

namespace Gateway.Hubs
{
    public class ChatHub : Hub
    {
        private readonly string DefaultRoom = "default";

        public override Task OnConnected()
        {
            var test = new User {Name = "nase"};

            return base.OnConnected();
        }

        public Task JoinGroup(string room)
        {
            return Groups.Add(Context.ConnectionId, room);
        }

        public Task LeaveGroup(string room)
        {
            return Groups.Remove(Context.ConnectionId, room);
        }
    }
}