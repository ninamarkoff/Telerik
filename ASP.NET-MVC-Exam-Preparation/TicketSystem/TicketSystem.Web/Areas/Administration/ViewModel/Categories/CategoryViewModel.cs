using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TicketSystem.Models;
using TicketSystem.Web.Infrastructure.Mapping;

namespace TicketSystem.Web.Areas.Administration.ViewModel.Categories
{
    public class CategoryViewModel : IMapFrom<Category>
    {
     
        [HiddenInput(DisplayValue = false)]
        public int? Id { get; set; }

        [Required]
        [UIHint("String")]
        public string Name { get; set; }
    }
}