using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNet.SignalR;

namespace Gateway.Provider
{
    class ActorUserProvider : IUserIdProvider
    {
        public string GetUserId(IRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
