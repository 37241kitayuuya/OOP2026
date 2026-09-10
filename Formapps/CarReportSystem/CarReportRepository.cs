using CarReportSystem;
using Microsoft.Data.Sqlite;
using System.Drawing.Imaging;
using System.Globalization;

namespace SQLiteProductSample;

//Productsテーブルに対するDB操作をまとめたクラス

public class CarReportRepository {
    public List<CarReport> GetAll() {

        var reports = new List<CarReport>();

        using var connection = Database.GetConnection();

        connection.Open();


        using var command = connection.CreateCommand();

        command.CommandText =
            """
            SELECT Id, Date, Author, Maker, CarName, Report, Picture
            FROM CarReports
            ORDER BY Id;
            """;

        using var reader = command.ExecuteReader();

        while (reader.Read()) {
            reports.Add(new CarReport {

                Id = reader.GetInt32(0),
                Date = DateTime.Parse(reader.GetString(1)),
                Author = reader.GetString(2),
                Maker = (CarReport.MakerGroup)reader.GetInt32(3),
                CarName = reader.GetString(4),
                Report = reader.GetString(5),
                Picture = reader.IsDBNull(6)
                ? null : BytesToImage(reader.GetFieldValue<byte[]>(6))

            });
        }
            return reports; ;
        }
    

    //reportを一件追加する。Create(INSERT)に相当する
    //戻り値として自動採番されたIDを返す
    public int Add(CarReport report) {
        //接続オブジェクトを生成
        using var connection = Database.GetConnection();

        //DBを開く
        connection.Open();

        //SQLを実行するためのコマンドオブジェクトを作る
        using var command = connection.CreateCommand();


        command.CommandText =
            """
            INSERT INTO CarReports (Date,Author,Maker,CarName,Report,Picture)
            VALUES ($date,$author,$maker,$carName,$report,$picture);

            SELECT last_insert_rowid();
            """;

        SetComandParameter(report, command);




        //一つの値を返すSQLを実行
        var result = command.ExecuteScalar();

        if (result is null)
            throw new InvalidOperationException("登録した商品のIDが取得できませんでした");

        //SQLLiteのINTRGERはlongとして帰るため,intへ変換する。
        return Convert.ToInt32((long)result);
    }

    private static void SetComandParameter(CarReport report, SqliteCommand command) {
        command.Parameters.AddWithValue("$Date", report.Date.ToString("yyyy-mm-dd", CultureInfo.InstalledUICulture));
        command.Parameters.AddWithValue("$Author", report.Author);
        command.Parameters.AddWithValue("$Maker", report.Maker);
        command.Parameters.AddWithValue("$CarName", report.CarName);
        command.Parameters.AddWithValue("$Report", report.Report);
        //image型の画像を、SQLLiteへ保存できるバイト型に変換する
        byte[]? pictureDate = ImageToBytes(report.Picture);
        //$picutureパラメータをBIOBとして追加
        var pictureParameter = command.Parameters.Add("$picuture", SqliteType.Blob);
        if (pictureParameter is not null) {
            pictureParameter.Value = pictureDate;
        } else {
            pictureParameter.Value = DBNull.Value;
        }
    }

    public void Update(CarReport report) {
        //接続オブジェクトを生成
        using var connection = Database.GetConnection();

        //DBを開く
        connection.Open();

        //SQLを実行するためのコマンドオブジェクトを作る
        using var command = connection.CreateCommand();


        command.CommandText =
            """
            UPDATE CarReports
            SET Date     =$date,
                Author   =$author,
                Maker    =$maker,
                CarName  =$carName,
                Report   =$report,
                Picture  =$picture
                WHERE Id =$id;
            """;
        SetComandParameter(report, command);
        command.Parameters.AddWithValue("$Date", report.Date.ToString("yyyy-mm-dd",CultureInfo.InstalledUICulture));
        command.Parameters.AddWithValue("$Author", report.Author);
        command.Parameters.AddWithValue("$Maker", report.Maker);
        command.Parameters.AddWithValue("$CarName", report.CarName);
        command.Parameters.AddWithValue("$Report", report.Report);
        //image型の画像を、SQLLiteへ保存できるバイト型に変換する
        byte[]? pictureDate = ImageToBytes(report.Picture);
        //$picutureパラメータをBIOBとして追加
        var pictureParameter = command.Parameters.Add("$picuture", SqliteType.Blob);
        if (pictureParameter is not null) { 
            pictureParameter.Value = pictureDate;
        } else {
            pictureParameter.Value = DBNull.Value;
        }

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
            DELETE FROM CarReports
            WHERE Id = $id;
            """;
        command.Parameters.AddWithValue("$id", id);
        command.ExecuteNonQuery();
        if (command.ExecuteNonQuery() == 0)
            throw new InvalidOperationException("修正対象の商品が見つかりませんでした。");
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


