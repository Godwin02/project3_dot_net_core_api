using System.ComponentModel.DataAnnotations;

namespace project3_api.Models_Tables_
{
    public class Product_table
    {
        [Key]//setting it as the product_id primary key
        public int product_id { get; set; }
        public string product_name { get; set; }
        public int product_price { get; set; }
        public int product_stock { get; set; }

    }
}
