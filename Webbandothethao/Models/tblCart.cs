using System.ComponentModel.DataAnnotations;

namespace Webbandothethao.Models
{
    public class tblCart
    {
        [Key]
        public int id { get; set; }

        public int user_id { get; set; }

        public int product_id { get; set; }

        public int quantity { get; set; }
    }
}
