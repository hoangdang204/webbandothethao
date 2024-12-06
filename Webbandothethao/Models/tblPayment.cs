using System.ComponentModel.DataAnnotations;

namespace Webbandothethao.Models
{
    public class tblPayment
    {
        [Key]
        public int id { get; set; }
        public int orderId { get; set; }
        public string? paymentMethod { get; set; }
        public string? status { get; set; }
        public string? transactionId { get; set; }
        public DateTime createdAt { get; set; } = DateTime.Now;

        public tblOrder? Order { get; set; }
    }
}
