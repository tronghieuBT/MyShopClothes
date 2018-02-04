using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Shop_Clothes.Model.Models
{
    [Table("Orders")]
    public class Order : Auditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] //Auto Increase
        public int ID { set; get; }

        [Required]
        public string CustomerName { set; get; }

        [Required]
        public string CustomerAddress { set; get; }

        [Required]
        public string CustomerEmail { set; get; }

        [Required]
        public string CustomerMoblie { set; get; }

        public string CustomerMessage { set; get; }

        public string PaymentMethod { set; get; }
        [Required]
        public string PaymentStatus { set; get; }

        [ForeignKey("OrderID")]
        public virtual OrderDetail OrderDetail { set; get; }
    }
}