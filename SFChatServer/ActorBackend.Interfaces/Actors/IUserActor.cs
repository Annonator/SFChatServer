using System.Threading.Tasks;
using Microsoft.ServiceFabric.Actors;

namespace ActorBackend.Interfaces.Actors
{
    public interface IUserActor : IActor
    {
        Task SetName(string name);
        Task<string> GetName();
    }
}