using System.ComponentModel.DataAnnotations;

namespace Webbandothethao.Models
{
    public class tblOrder
    {
        [Key]
        public int id { get; set; }
        public int userId { get; set; }
        public decimal totalPrice { get; set; }
        public string? status { get; set; }
        public DateTime createdAt { get; set; } = DateTime.Now;
        public DateTime updatedAt { get; set; } = DateTime.Now;

        public tblUser? user { get; set; }
        public ICollection<tblOrderDetail>? OrderDetails { get; set; }
    }
}
