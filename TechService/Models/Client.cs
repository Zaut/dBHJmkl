using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TechService.Models
{
    public class Client
    {
        public int ClientID { get; set; }
        public string FIO { get; set; }
        public string Phone { get; set; }
        public string Adress { get; set; }
        public bool Status { get; set; }
        public int CartID { get; set; }

        public Client() { }
        public Client(int ClientID_, string FIO_, string Phone_, string Adress_, bool Status_, int CartID_)
        {
            this.ClientID = ClientID_;
            this.FIO = FIO_;
            this.Phone = Phone_;
            this.Adress = Adress_;
            this.Status = Status_;
            this.CartID = CartID_;
        }
        public virtual IEnumerable<Cart> Carts { get; set; }
    }
}