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

namespace TicketSystem.Web.Controllers
{
    public class TicketsController : BaseController
    {
        public TicketsController(ITicketSystemData data) :
            base(data)
        {

        }

        [Authorize]
        public ActionResult All()
        {
            return View();
        }

        [Authorize]
        [HttpPost]
        public ActionResult ReadTickets([DataSourceRequest]DataSourceRequest request)
        {
            var tickets = this.Data.Tickets
                .All()
                .Project()
                .To<ListTicketViewModel>();

            return Json(tickets.ToDataSourceResult(request));
                
        }

        [Authorize]       
        public ActionResult Add()
        {
            var addTicketViewModel = new AddTicketViewModel
            {
                Categories = this.Data.Categories
                .All()
                .Select(c => new SelectListItem
                {
                    Value = c.Id.ToString(),
                    Text = c.Name
                })
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

            ticket.Categories = this.Data.Categories
               .All()
               .Select(c => new SelectListItem
               {
                   Value = c.Id.ToString(),
                   Text = c.Name
               });

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
    }
}