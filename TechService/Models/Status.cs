using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TechService.Models
{
    public class Status
    {
        public int StatusId { get; set; }
        public string Role { get; set; }

        public Status(int StatusId_, string Role_)
        {
            this.StatusId = StatusId_;
            this.Role = Role_;
        }
        Status() { }
    }
}