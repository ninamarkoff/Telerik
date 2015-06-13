using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TicketSystem.Web.ViewModels.Home;

namespace TicketSystem.Web.Infrastructure.Services.Contracts
{
    public interface IHomeServices
    {
        IList<TicketViewModel> GetIndexViewModel(int numberOfTickets);
    }
}
