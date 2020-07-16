using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TechService.Models
{
    public class UserInfo
    {
        public int ID { get; set; }
        public string Login { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Mail { get; set; }

        public UserInfo(int ID_,string Login_, string FirstName_, string LastName_, string Phone_, string Mail_)
        {
            this.ID = ID_;
            this.Login = Login_;
            this.FirstName = FirstName_;
            this.LastName = LastName_;
            this.Phone = Phone_;
            this.Mail = Mail_;
        }
        UserInfo() { }

        public virtual IEnumerable<HashPass>HashPasses  { get; set; }
        public virtual IEnumerable<Status>Statuses  { get; set; }
    }
}