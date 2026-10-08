using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MvcBasicSample.Deta;

namespace MvcBasicSample.Controllers;
public class ProductsController: Controller {
    private readonly AppDbcontext _db;//DBへ問い合わせるためのフィールド

    //ASP.NET coreから必要な
    public ProductsController(AppDbcontext db) {
        _db = db;
    }


    //product/indexで商品一覧を取得
public async Task<IActionResult> Index() {
        var products = await _db.Products
            .Where(product=>product.price>500)
            .OrderBy(product=> product.Id).ToListAsync();
        return View(products);
    }
    
}

