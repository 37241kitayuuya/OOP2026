
using Microsoft.AspNetCore.Mvc;  // Controller と IActionResult を使用
using MvcBasicSample.Models;
namespace MvcBasicSample.Controllers;
   
// URL のHelloに対応する要求を受け取るController
    public class HelloController : Controller {
       
    // /Hello/Index で呼び出されるAction 
        public IActionResult Index() {
        //商品一件のオブジェクトを作る
        var products = new List<Product>{
            new Product{
            name = "ハンバーガー",
            price = 500
        },
            new Product {
            name = "紅茶",
            price = 450 }
        };

            return View(products);
        }
    }

