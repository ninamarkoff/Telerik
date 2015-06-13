using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TicketSystem.Web.ViewModels.Home;
using AutoMapper.QueryableExtensions;
using TicketSystem.Web.Infrastructure.Services.Contracts;
using TicketSystem.Web.Infrastructure.Services.Base;
using TicketSystem.Data;

namespace TicketSystem.Web.Infrastructure.Services
{
    public class HomeServices : BaseServices, IHomeServices
    {
        public HomeServices(ITicketSystemData data)
            : base(data)
        {

        }

        public IList<TicketViewModel> GetIndexViewModel(int numberOfTickets)
        {
             var indexViewModel = this.Data
                .Tickets
                .All()
                .OrderByDescending(t => t.Comments.Count())
                .Take(numberOfTickets)
                .Project()
                .To<TicketViewModel>()
                .ToList();

            return indexViewModel;
        }
    }
}