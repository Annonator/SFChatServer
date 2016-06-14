using System.Web.Http;
using ActorBackend.Interfaces.Actors;
using Microsoft.ServiceFabric.Actors;
using Microsoft.ServiceFabric.Actors.Client;
using Utility;

namespace Gateway.Controllers
{
    public class UserController : ApiController
    {
        /// <summary>
        ///     Das ist ein Test
        /// </summary>
        /// <param name="name">Der zu setzende Name</param>
        [HttpPost]
        public bool SetName(string name)
        {
            var proxy = ActorProxy.Create<IUserActor>(new ActorId(1), FabricConfig.ServiceUri);
            proxy.SetName(name);

            return true;
        }

        [HttpGet]
        public string GetName()
        {
            var proxy = ActorProxy.Create<IUserActor>(new ActorId(1), FabricConfig.ServiceUri);

            return proxy.GetName().Result.ToString();
        }
    }
}