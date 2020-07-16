using System.Collections.Generic;

namespace TechService.Models.Repository
{
    public class Repository
    {
        private EfDbContext context = new EfDbContext();
        public IEnumerable<Category> Categories { get { return context.Categories; } }
        public IEnumerable<UserInfo> UserInfos { get { return context.UserInfos; } }
        public void SaveOrder(Order order)
        {
            //if (order.OrderId == 0)
            //{
            //    order = context.Orders.Add(order);
            //    foreach (OrderLine line in order.OrderLines)
            //    {
            //        context.Entry(line.Game).State = System.Data.Entity.EntityState.Modified;
            //    }
            //}
            //else
            //{
            //    Order dbOrder = context.Orders.Find(order.OrderId);
            //    if (dbOrder != null)
            //    {
            //        dbOrder.Name = order.Name;
            //        dbOrder.Line1 = order.Line1;
            //        dbOrder.Line2 = order.Line2;
            //        dbOrder.Line3 = order.Line3;
            //        dbOrder.City = order.City;
            //        dbOrder.GiftWrap = order.GiftWrap;
            //        dbOrder.Dispatcher = order.Dispatcher;
            //    }
            //}
            //context.SaveChanges();
        }


    }
}