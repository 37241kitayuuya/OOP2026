using CarReportSystem;
using Microsoft.Data.Sqlite;
using System.Diagnostics;
using System.Drawing.Imaging;
using System.Xml.Linq;

namespace SQLiteProductSample;

//Productsテーブルに対するDB操作をまとめたクラス

public class CarReportRepository {
    public List<CarReport> GetAll() {

        var products = new List<CarReport>();

        using var connection = Database.GetConnection();

        connection.Open();


        using var command = connection.CreateCommand();

        command.CommandText =
            """
            SELECT Id, Date, Author, Maker, CarName, Report, Picture
            FROM CarReport
            ORDER BY Id;
            """;

        using var reader = command.ExecuteReader();

        while (reader.Read()) {
            CarReport report = new CarReport();

            report.Id = reader.GetInt32(0);
            report.Maker = (CarReport.MakerGroup)reader.GetInt32(1);
            report.Date = DateTime.Parse(reader.GetString(2));
            report.Author = reader.GetString(3);
            report.CarName = reader.GetString(4);
            report.Report = reader.GetString(5);
            report.Picture =
            CarReport.Add(report);
        }
        return CarReport; ;
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
        command.Parameters.AddWithValue("$price", price);

        //一つの値を返すSQLを実行
        var result = command.ExecuteScalar();

        if (result is null)
            throw new InvalidOperationException("登録した商品のIDが取得できませんでした");

        //SQLLiteのINTRGERはlongとして帰るため,intへ変換する。
        return Convert.ToInt32((long)result);
    }
    public void Update(CarReport product) {
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
                Price =$price
                WHERE Id =$id;
            """;

        command.Parameters.AddWithValue("$name",product.Name);
        command.Parameters.AddWithValue("$price",product .price);
        command.Parameters.AddWithValue("$id", product.Id);

        //更新件数が０なら対象が存在しない
        if (command.ExecuteNonQuery() == 0)
            throw new InvalidOperationException("修正対象の商品が見つかりませんでした。");
        //一つの値を返すSQLを実行
        //var result = command.ExecuteScalar();

        //if (result is null)
            //throw new InvalidOperationException("登録した商品のIDが取得できませんでした");

       
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
        command.Parameters.AddWithValue("$id",id);
        command.ExecuteNonQuery();
    }

    // ImageをSQLiteへ保存できるbyte[]へ変換する
    private static byte[]? ImageToBytes(Image? image) {
        if (image is null) return null;

        using var stream = new MemoryStream();
        // DBへはPNG形式で保存
        image.Save(stream, ImageFormat.Png);
        return stream.ToArray();
    }

    // SQLiteのBLOB（byte[]）をImageへ変換する
    private static Image BytesToImage(byte[] data) {
        using var stream = new MemoryStream(data);
        using var image = Image.FromStream(stream);
        // MemoryStream破棄後も利用できるようBitmapとしてコピーする。
        return new Bitmap(image);
    }
}


