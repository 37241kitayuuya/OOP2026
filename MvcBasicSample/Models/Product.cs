using System.ComponentModel.DataAnnotations;


namespace MvcBasicSample.Models {
    
    public class Product {
        public int id { get; set; }//主キー

        [Required]//必須項目
        public string name { get; set; } = string.Empty;
        public int price { get; set; }
    }
}
