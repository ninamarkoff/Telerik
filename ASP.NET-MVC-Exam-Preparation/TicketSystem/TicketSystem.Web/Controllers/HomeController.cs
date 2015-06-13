using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TicketSystem.Data;
using TicketSystem.Web.ViewModels.Home;

using AutoMapper.QueryableExtensions;
using TicketSystem.Web.Infrastructure.Services.Contracts;

namespace TicketSystem.Web.Controllers
{
    public class HomeController : BaseController
    {
        private IHomeServices homeServices;
        public HomeController(ITicketSystemData data, IHomeServices homeServices):
            base(data)
        {
            this.homeServices = homeServices;
        }

        [OutputCache(Duration = 60 * 60)]
        public ActionResult Index()
        {         
            return View(this.homeServices.GetIndexViewModel(6));
        }

        public ActionResult Error()
        {
            return View();
        }
    }
}