using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using ActorBackend.Interfaces.Actors;
using Microsoft.ServiceFabric.Actors;
using Microsoft.ServiceFabric.Actors.Client;

namespace Gateway.Controllers
{
    class RoomController : ApiController
    {
        [HttpPost]
        public bool AddUserToRoom(string userName, string roomName)
        {
            var user = ActorProxy.Create<IUserActor>(new ActorId("test"), Utility.FabricConfig.ServiceUri);
            return true;
        }
    }
}
