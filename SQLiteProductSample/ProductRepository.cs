using Microsoft.Data.Sqlite;

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
            SELECT Id Name. Price
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

}


