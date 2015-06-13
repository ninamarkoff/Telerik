using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TicketSystem.Data;

using AutoMapper.QueryableExtensions;
using TicketSystem.Web.ViewModels.Comments;
using TicketSystem.Web.ViewModels.Tickets;
using TicketSystem.Models;
using AutoMapper;
using System.IO;
using Kendo.Mvc.UI;
using Kendo.Mvc.Extensions;
using TicketSystem.Web.Infrastructure.Populators;

namespace TicketSystem.Web.Controllers
{
    public class TicketsController : BaseController
    {
        private IDropDownListPopulator populator;
        public TicketsController(ITicketSystemData data, IDropDownListPopulator populator) :
            base(data)
        {
            this.populator = populator;
        }

        [Authorize]
        public ActionResult All(int? category)
        {
            return View(category);
        }

        [Authorize]
        [HttpPost]
        public ActionResult ReadTickets([DataSourceRequest]DataSourceRequest request, int? category)
        {
            var ticketsQuery = this.Data.Tickets.All();

            if (category != null)
            {
                ticketsQuery = ticketsQuery.Where(t => t.CategoryId == category.Value);
            }
            
            var tickets = ticketsQuery
                .Project()
                .To<ListTicketViewModel>();

            return Json(tickets.ToDataSourceResult(request));

        }

        [Authorize]
        public ActionResult Add()
        {
            var addTicketViewModel = new AddTicketViewModel
            {
                Categories = this.populator.GetCategories()
            };

            return View(addTicketViewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize]
        public ActionResult Add(AddTicketViewModel ticket)
        {
            if (ticket != null && ModelState.IsValid)
            {
                var dbTicket = Mapper.Map<Ticket>(ticket);
                dbTicket.Author = this.UserProfile;

                if (ticket.UploadedImage != null)
                {
                    using (var memory = new MemoryStream())
                    {
                        ticket.UploadedImage.InputStream.CopyTo(memory);
                        var content = memory.GetBuffer();

                        dbTicket.Image = new Image
                        {
                            Content = content,
                            FileExtension = ticket.UploadedImage.FileName.Split(new[] { '.' }).Last()
                        };
                    }
                }


                this.Data.Tickets.Add(dbTicket);
                this.Data.SaveChanges();

                return RedirectToAction("All", "Tickets");
            }

            ticket.Categories = this.populator.GetCategories();

            return View(ticket);
        }


        public ActionResult Details(int id)
        {
            var ticket = this.Data
                .Tickets
                .All()
                .Where(t => t.Id == id)
                .Project()
                .To<TicketDetailsViewModel>()
                .FirstOrDefault();

            if (ticket == null)
            {
                throw new HttpException(404, "Ticket not found");
            }

            ticket.Comments = this.Data
                .Comments
                .All()
                .Where(t => t.TicketId == id)
                .OrderByDescending(c => c.Id)
                .Project()
                .To<CommentViewModel>()
                .ToList();

            return View(ticket);
        }

        public ActionResult Image(int id)
        {
            var image = this.Data.Images.GetById(id);

            if (image == null)
            {
                throw new HttpException(404, "Image not found");
            }

            return File(image.Content, "image/" + image.FileExtension);
        }

        public ActionResult GetCategories()
        {
            return Json(this.populator.GetCategories(), JsonRequestBehavior.AllowGet);
        }
    }
}