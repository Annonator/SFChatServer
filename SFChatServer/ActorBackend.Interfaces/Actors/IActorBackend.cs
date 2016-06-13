using System.Threading.Tasks;
using Microsoft.ServiceFabric.Actors;

namespace ActorBackend.Interfaces.Actors
{
    /// <summary>
    ///     This interface defines the methods exposed by an actor.
    ///     Clients use this interface to interact with the actor that implements it.
    /// </summary>
    public interface IActorBackend : IActor
    {
        /// <summary>
        ///     TODO: Replace with your own actor method.
        /// </summary>
        /// <returns></returns>
        Task<int> GetCountAsync();

        /// <summary>
        ///     TODO: Replace with your own actor method.
        /// </summary>
        /// <param name="count"></param>
        /// <returns></returns>
        Task SetCountAsync(int count);
    }
}