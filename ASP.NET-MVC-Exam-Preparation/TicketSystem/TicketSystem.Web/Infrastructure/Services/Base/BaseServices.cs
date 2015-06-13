using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TicketSystem.Data;

namespace TicketSystem.Web.Infrastructure.Services.Base
{
    public abstract class BaseServices
    {
        protected ITicketSystemData Data {get; private set;}

        public BaseServices(ITicketSystemData data)
        {
            this.Data = data;
        }
    }
}