using Microsoft.EntityFrameworkCore;
using MvcBasicSample.Models;
using System.Security.Cryptography;

namespace MvcBasicSample.Deta {
    public class AppDbcontext: DbContext {

        public AppDbcontext(DbContextOptions<AppDbcontext> options)
            : base(options) {//受け取った設定を親クラスに渡す

        }

        //productsテーブルをproduct　型として問い合わせるためのプロパティ
        public DbSet<Product> Products => Set<Product>();
    }
}
