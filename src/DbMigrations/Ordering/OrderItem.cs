using System;
using System.Collections.Generic;

#nullable disable

namespace DbMigrations.Ordering
{
    public partial class OrderItem
    {
        public int Id { get; set; }
        public Guid OrderId { get; set; }
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }
        public int Units { get; set; }
        public string PictureUrl { get; set; }

        public virtual Order Order { get; set; }
    }
}
