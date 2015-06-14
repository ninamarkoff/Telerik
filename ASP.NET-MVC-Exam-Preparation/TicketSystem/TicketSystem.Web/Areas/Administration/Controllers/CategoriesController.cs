﻿namespace TicketSystem.Web.Areas.Administration.Controllers
{
    using System.Web.Mvc;

    using AutoMapper;
    using AutoMapper.QueryableExtensions;

    using TicketSystem.Data;

    using Kendo.Mvc.UI;
    using Kendo.Mvc.Extensions;
    using TicketSystem.Models;
    using System.Collections;

    using System.Linq;

    using Model = TicketSystem.Models.Category;
    using ViewModel = TicketSystem.Web.Areas.Administration.ViewModel.Categories.CategoryViewModel;

    public class CategoriesController : KendoGridAdministrationController
    {
        public CategoriesController(ITicketSystemData data)
            : base(data)
        {
        }

        public ActionResult Index()
        {
            return View();
        }

        protected override IEnumerable GetData()
        {
            return this.Data
                .Categories
                .All()
                .Project()
                .To<ViewModel>();
        }

        protected override T GetById<T>(object id)
        {
            return this.Data.Categories.GetById(id) as T;
        }

        [HttpPost]
        public ActionResult Create([DataSourceRequest]DataSourceRequest request, ViewModel model)
        {
            var dbModel = base.Create<Model>(model);
            if (dbModel != null) model.Id = dbModel.Id;
            return this.GridOperation(model, request);
        }

        [HttpPost]
        public ActionResult Update([DataSourceRequest]DataSourceRequest request, ViewModel model)
        {
            base.Update<Model, ViewModel>(model, model.Id);
            return this.GridOperation(model, request);
        }

        [HttpPost]
        public ActionResult Destroy([DataSourceRequest]DataSourceRequest request, ViewModel model)
        {
            if (model != null && ModelState.IsValid)
            {
                var category = this.Data.Categories.GetById(model.Id.Value);

                foreach (var ticketId in category.Tickets.Select(t => t.Id).ToList())
                {                  

                    var comments = this.Data
                        .Comments
                        .All()
                        .Where(c => c.TicketId == ticketId)
                        .Select(c => c.Id)
                        .ToList();

                    foreach (var commentId in comments)
                    {
                        this.Data.Comments.Delete(commentId);
                    }
                    this.Data.SaveChanges();

                    this.Data.Tickets.Delete(ticketId);
                }

                this.Data.Categories.Delete(category);
                this.Data.SaveChanges();
            }

            return this.GridOperation(model, request);
        }
    }
}