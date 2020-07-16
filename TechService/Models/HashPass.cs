using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TechService.Models
{
    public class HashPass
    {
        public int HashPassId { get; set; }
        public string HashPassword { get; set; }

        public HashPass(int HashPassId_,string HashPassword_)
        {
            this.HashPassId = HashPassId_;
            this.HashPassword = HashPassword_;
        }
        HashPass() { }
    }
}