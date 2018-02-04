using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Shop_Clothes.Model.Models
{
    [Table("OrderDetails")]
    public class OrderDetail
    {
        public int OrderID { set; get; }
        public int ProductID { set; get; }
        public int Quantity { set; get; }

        public virtual IEnumerable<Order> Order { set; get; }
    }
}