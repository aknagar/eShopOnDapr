using System;
using System.Collections.Generic;

#nullable disable

namespace DbMigrations.Ordering
{
    public partial class Order
    {
        public Order()
        {
            OrderItems = new HashSet<OrderItem>();
        }

        public Guid Id { get; set; }
        public int OrderNumber { get; set; }
        public DateTime OrderDate { get; set; }
        public string OrderStatus { get; set; }
        public string Description { get; set; }
        public string AddressStreet { get; set; }
        public string AddressCity { get; set; }
        public string AddressState { get; set; }
        public string AddressCountry { get; set; }
        public string AddressZipCode { get; set; }
        public string BuyerId { get; set; }
        public string BuyerName { get; set; }

        public virtual ICollection<OrderItem> OrderItems { get; set; }
    }
}
