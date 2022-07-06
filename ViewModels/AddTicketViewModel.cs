
using FinalProReRe.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FinalProRere.ViewModels
{
    public class AddTicketViewModel
    {

        public IEnumerable<SelectListItem> ApplicationUsers { get; set; }
        public Ticket Ticket { get; set; }

    }
}