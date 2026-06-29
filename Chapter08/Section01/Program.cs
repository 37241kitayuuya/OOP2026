namespace Section01 {
    internal class Program {
        static private Dictionary<string, string> pre0fficeDict = new Dictionary<string, string>();
        
        
        static void Main(string[] args) {
            string? pref, prefCaptalLocation;

            Console.WriteLine("県庁所在地の登録【入力終了：ctrl+'z'】");


            while (true) {
                //都道府県の出力
                Console.Write("都道府県:");
                pref = Console.ReadLine();
                if (pref == null) break; //無限ループを抜ける（ｃｔｒｌ+ｚ）

                //県庁所在地の入力
                Console.Write("県庁所在地:");
                prefCaptalLocation = Console.ReadLine();
                Console.WriteLine();
                //既に登録済みかの判断
                if (pre0fficeDict.ContainsKey(pref)) {
                    Console.WriteLine("上書きしますか？(Y/N)");
                    if (Console.ReadLine() == "N") ;
                }
                if (prefCaptalLocation == null) break;

                //県庁所在地登録処理
                pre0fficeDict.Add(pref, prefCaptalLocation);
                foreach(var item in pre0fficeDict) {
                }
            }
            Boolean endFlag = false; //終了フラグ
            while (true) {
                int menu = menuDisp();

                switch (menu) {
                    case 1:
                        allDisp();
                        break;

                    case 2:
                        searchPrefCaptalLocation();
                        break;

                    case 9:
                        endFlag = true;
                        return;

                    default:
                        Console.WriteLine("メニュー番号が正しくありません。");
                        break;
                }
            }
        }
        //メニュー表示
         private static int menuDisp() {
            Console.WriteLine("\n**** メニュー　****");
            Console.WriteLine("1:一覧表示");
            Console.WriteLine("2:検索");
            Console.WriteLine("9:終了");
            Console.Write(">");
            //メニュー番号を入力させて呼び出し元へ返却
            return int.Parse(Console.ReadLine());
            //int menu;
            //if (int.TryParse(Console.ReadLine(), out menu)) {
           // }
            //return 0; 
        }

        //一覧表示処理
        private static void allDisp() {
            //コレクションの中身をすべて出力
            foreach(var p in pre0fficeDict) {
                Console.WriteLine($"{p.Key}の県庁所在地は{p.Value}です。");
            }
        }
        //検索処理
        private static void searchPrefCaptalLocation() {
            Console.Write("都道府県");
            string? searchPref = Console.ReadLine();
            if (searchPref is null) return;
            //検索結果を表示
            if (pre0fficeDict.ContainsKey(searchPref)) {
                Console.WriteLine(searchPref + "の県庁所在地は" + pre0fficeDict[searchPref] + "です");
            }
        }
    }
    }

