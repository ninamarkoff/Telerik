using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;

namespace TicketSystem.Web.Infrastructure.Populators
{
    public interface IDropDownListPopulator
    {
        IEnumerable<SelectListItem> GetCategories();
    }
}
