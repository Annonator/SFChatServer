using System.Collections.Generic;
using System.Threading.Tasks;
using ActorBackend.Interfaces.Entities;
using Microsoft.ServiceFabric.Actors;

namespace ActorBackend.Interfaces.Actors
{
    public interface IRoomActor : IActor
    {
        Task AddUser(User user);

        Task<IList<User>> GetUsers();
    }
}