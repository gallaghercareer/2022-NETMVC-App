using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace FinalProReRe.Models
{
    public class Ticket
    {
        public int Id { get; set; }

        public virtual ApplicationUser ApplicationUser { get; set; }

        [ForeignKey("ApplicationUser")]
        public string ApplicationUserId { get; set; }

        public DateTime Date { get; set; }

        public bool Resolved { get; set; }
        
        [Required]
        public string Instructions { get; set; }
       


    }
}