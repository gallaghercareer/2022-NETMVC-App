using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace FinalProReRe.Models
{
    public class Comment
    {
        public int Id { get; set; }

        [ForeignKey("ApplicationUser")]
        //[Column(Order = 0)]
        public string ApplicationUserId { get; set; }
        public ApplicationUser ApplicationUser { get; set; }

        public Ticket Ticket { get; set; }

        [ForeignKey("Ticket")]
        //[Column(Order = 1)]
        public int TicketId { get; set; }

        public string textBox { get; set; }

        public string name { get; set; }
    }
}