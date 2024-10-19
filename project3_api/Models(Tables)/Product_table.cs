using System.ComponentModel.DataAnnotations;

namespace project3_api.Models_Tables_
{
    public class Product_table
    {
        [Key]//setting it as the product_id primary key
        public int productId { get; set; }
        public string productName { get; set; }
        public int productPrice { get; set; }
        public int productStock { get; set; }

    }
}
