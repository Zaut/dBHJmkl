using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TechService.Models
{
    public class Service
    {
        public int ServiceId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int CategoryId { get; set; }
        public int MasterId { get; set; }
        public int CarId { get; set; }
        public decimal Price { get; set; }

        public Service() { }
        public Service(int ServiceId_, string Name_, string Description_, int CategoryId_, int MasterId_, int CarId_, decimal Price_)
        {
            this.ServiceId = ServiceId_;
            this.Name = Name_;
            this.Description = Description_;
            this.CategoryId = CategoryId_;
            this.MasterId = MasterId_;
            this.CarId = CarId_;
            this.Price = Price_;
        }
        public virtual IEnumerable<Category> Categories { get; set; }
        public virtual IEnumerable<Master> Masters { get; set; }
        public virtual IEnumerable<Car> Cars { get; set; }
    }
}