using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.Sqlite;

namespace CarReportSystem {
    //SQLiteデータベースへの接続と初期化を担当するクラス
    public static class Database {
        //ＤＢファイルの保存場所
        private static readonly string DatabasePath =
            Path.Combine(AppContext.BaseDirectory, "carreport.db");

        //SQLiteへ接続するための接続文字列
        private static readonly string connectionString =
         $"Data Source={DatabasePath}";

        //DBファイルの保存場所を外部から確認するための読み取りプロパティ
        public static string FilePath => DatabasePath;


        public static SqliteConnection GetConnection() 
            => new SqliteConnection(connectionString);

        
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
            CREATE TABLE IF NOT EXISTS Products (
                Id      INTEGER PRIMARY KEY AUTOINCREMENT,
                Date    TEXT    NOT NULL,
                Author  TEXT    NOT NULL,
                Maker   INTEGER NOT NULL,
                CarName TEXT    NOT NULL,
                Report  TEXT    NOT NULL,
                Picture BLOB
            );
            """;


            //結果業を返さないSQLを実行する
            command.ExecuteNonQuery();
        }
    }
}
