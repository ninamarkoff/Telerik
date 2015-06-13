using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TicketSystem.Data;
using TicketSystem.Web.Infrastructure.Caching;

namespace TicketSystem.Web.Infrastructure.Populators
{
    public class DropDownListPopulator : IDropDownListPopulator
    {
        private ITicketSystemData data;
        private ICacheService cache;

        // uses unit of work, categories are being populated; avoiding copy/paste in TicketsController Add methods
        // get data from cache, not directly from the controller

        public DropDownListPopulator(ITicketSystemData data, ICacheService cache)
        {
            this.data = data;
            this.cache = cache;
        }

        public IEnumerable<SelectListItem> GetCategories()
        {
            var categories = this.cache.Get<IEnumerable<SelectListItem>>("categories", () =>
                {
                    return this.data.Categories
                .All()
                .Select(c => new SelectListItem
                    {
                        Value = c.Id.ToString(),
                        Text = c.Name
                    });
                })
                .ToList();

            return categories;
        }
    }
}