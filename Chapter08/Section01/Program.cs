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

                if (prefCaptalLocation == null) break;

                //県庁所在地登録処理
                pre0fficeDict.Add(pref, prefCaptalLocation);
                foreach(var item in pre0fficeDict) {
                }
            } while (true) {
                int menu = menuDisp();

                switch (menu) {
                    case 1:
                        allDisp();
                        break;

                    case 2:
                        searchPrefCaptalLocation();
                        break;

                    case 9:
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
            int menu;
            if (int.TryParse(Console.ReadLine(), out menu)) {
                return menu;
            }
            //メニュー番号を入力させて呼び出し元へ返却
            return 0; 
        }

        //一覧表示処理
        private static void allDisp() {

            //コレクションの中身をすべて出力

        }
        //検索処理
        private static void searchPrefCaptalLocation() {
            Console.Write("都道府県");
            string? searchPref = Console.ReadLine();
        }
    }
    }

