using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ActorBackend.Interfaces.Actors;
using ActorBackend.Interfaces.Entities;
using Microsoft.ServiceFabric.Actors.Runtime;

namespace ActorBackend.Actors
{
    class RoomActor : Actor, IRoomActor
    {
        private readonly string UserListName = "UserListName";

        protected override Task OnActivateAsync()
        {
            this.StateManager.TryAddStateAsync(this.UserListName, new List<User>());

            return base.OnActivateAsync();
        }

        public async Task AddUser(User user)
        {
            var state = await this.StateManager.GetStateAsync<IList<User>>(this.UserListName);

            state.Add(user);

            await this.StateManager.AddOrUpdateStateAsync(this.UserListName, state, (s, userList) => state);
        }

        public Task<IList<User>> GetUsers()
        {
            return this.StateManager.GetStateAsync<IList<User>>(this.UserListName);
        }
    }
}
