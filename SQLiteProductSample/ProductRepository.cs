using Microsoft.Data.Sqlite;
using System.Diagnostics;
using System.Xml.Linq;

namespace SQLiteProductSample;

//Productsテーブルに対するDB操作をまとめたクラス

public class ProductRepository {
    public List<Product> GetAll() {

        var products = new List<Product>();

        using var connection = Database.GetConnection();

        connection.Open();


        using var command = connection.CreateCommand();

        command.CommandText =
            """
            SELECT Id, Name, Price
            FROM Products
            ORDER BY Id;
            """;

        using var reader = command.ExecuteReader();

        while (reader.Read()) {
            products.Add(new Product {
                Id = reader.GetInt32(0),
                Name = reader.GetString(1),
                price = reader.GetInt32(2)

            });

        }
        return products;
    }

    //商品を一件追加する。Create(INSERT)に相当する
    //戻り値として自動採番されたIDを返す
    public int Add(string name, int price) {
        //接続オブジェクトを生成
        using var connection = Database.GetConnection();

        //DBを開く
        connection.Open();

        //SQLを実行するためのコマンドオブジェクトを作る
        using var command = connection.CreateCommand();

        
        command.CommandText =
            """
            INSERT INTO Products (Name,Price)
            VALUES ($name, $price);

            SELECT last_insert_rowid();
            """;

        command.Parameters.AddWithValue("$name", name);
        command.Parameters.AddWithValue("$Price", price);

        //一つの値を返すSQLを実行
        var result = command.ExecuteScalar();

        if (result is null)
            throw new InvalidOperationException("登録した商品のIDが取得できませんでした");

        //SQLLiteのINTRGERはlongとして帰るため,intへ変換する。
        return Convert.ToInt32((long)result);
    }
    public int Update(Product product) {
        //接続オブジェクトを生成
        using var connection = Database.GetConnection();

        //DBを開く
        connection.Open();

        //SQLを実行するためのコマンドオブジェクトを作る
        using var command = connection.CreateCommand();


        command.CommandText =
            """
            UPDATE Products
            SET Name =$name,
                price =$price
                WHRER Id =$id;
            """;

        command.Parameters.AddWithValue("$name",product.Name);
        command.Parameters.AddWithValue("$Price",product .price);
        command.Parameters.AddWithValue("id", product.Id);

        //更新件数が０なら対象が存在しない
        if (command.ExecuteNonQuery() == 0)
            throw new InvalidOperationException("修正対象の商品が見つかりませんでした。");
        //一つの値を返すSQLを実行
        var result = command.ExecuteScalar();

        if (result is null)
            throw new InvalidOperationException("登録した商品のIDが取得できませんでした");

       
    }
    public void Delete(int id) {
        //接続オブジェクトを生成
        using var connection = Database.GetConnection();
        //DBを開く
        connection.Open();
        //接続オブジェクトを生成
        using var command = connection.CreateCommand();
        command.CommandText =
            """
            DELETE FROM Products
            WHERE Id = $id;
            """;
        command.Parameters.AddWithValue("$id,id");
        command.ExecuteNonQuery();
    }
    }


