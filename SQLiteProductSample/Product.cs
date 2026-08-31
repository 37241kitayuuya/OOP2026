using System.ComponentModel;

namespace SQLiteProductSample;
//商品１件分のデータを表すクラス
public class Product
{
　　//商品ID　　
    [DisplayName("ID")]
    public int Id { get; set; }
   
    //商品名
    [DisplayName("商品名")]
    public string Name { get; set; } = string.Empty;
    
    //商品価格
    [DisplayName("価格")]
    public int price { get; set; }
}
