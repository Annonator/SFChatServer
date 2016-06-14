using System.Threading.Tasks;
using ActorBackend.Interfaces.Actors;
using ActorBackend.Interfaces.Entities;
using Microsoft.ServiceFabric.Actors.Runtime;

namespace ActorBackend.Actors
{
    [StatePersistence(StatePersistence.Persisted)]
    internal class UserActor : Actor, IUserActor
    {
        private const string UserState = "user";

        /// <summary>
        ///     This method is called right after the actor is activated and before any method call or reminders are dispatched on
        ///     it.
        /// </summary>
        /// <returns>A <see cref="T:System.Threading.Tasks.Task">Task</see> that represents outstanding OnActivateAsync operation.</returns>
        protected override Task OnActivateAsync()
        {
            this.StateManager.TryAddStateAsync(UserState, new User {Name = "NASE"});

            return base.OnActivateAsync();
        }

        public async Task SetName(string name)
        {
            var state = await this.StateManager.GetStateAsync<User>(UserState);

            state.Name = name;

            await this.StateManager.AddOrUpdateStateAsync(UserState, state, (s, user) => state);
        }

        public Task<string> GetName()
        {
            var state = this.StateManager.GetStateAsync<User>(UserState).Result;

            return Task.FromResult(state.Name);
        }
    }
}