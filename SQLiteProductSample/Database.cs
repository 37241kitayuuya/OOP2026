using Microsoft.Data.Sqlite;

namespace SQLiteProductSample;
//SQLiteデータベースへの接続と初期化を担当するクラス
public static class Database
{
    //ＤＢファイルの保存場所
    private static readonly string DatabasePath =
        Path.Combine(AppContext.BaseDirectory, "products.db");

    //SQLiteへ接続するための接続文字列
    private static readonly string connectionString =
     $"Date Source={DatabasePath}";

    //DBファイルの保存場所を外部から確認するための読み取りプロパティ
    public static string FilePath => DatabasePath;


    public static SqliteConnection GetConnection() {
        return new SqliteConnection(connectionString);

         }
    public static void Intializa() {
        using var connection = GetConnection();

        //DBを開く
        connection.Open();

        //SQLを実行するためのコマンドオブジェクトを作る
        using var command = connection.CreateCommand();

        //Products低ブルを作るSQL
        //IF NOT EXISTS により、既にテーブルがあってもエラーにならない
        command.CommandText =
            """
            CREATE TABLE IF NOT EXISTS Products(
                Id      INTEGER PROMARY KEY AUTOINCREMENT,
                Name    TEXT NOT NULL,
                Price   INTEGER NOT NULL CHECK <Price >= 0)
            );
            """;


        //結果業を返さないSQLを実行する
        command.ExecuteNonQuery();
    }
    }

