using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TicketSystem.Common;
using TicketSystem.Data;
using TicketSystem.Web.Controllers;

namespace TicketSystem.Web.Areas.Administration.Controllers
{
    [Authorize(Roles = GlobalConstants.AdminRole)]
    public abstract class AdminController : BaseController
    {
       public AdminController(ITicketSystemData data):
           base(data)
        {

        }
    }
}