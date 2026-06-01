using System.Collections.Immutable;

namespace section01 {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("Hello, World!");
            // var obj = new PasswordPolicy("aaaaa", "bbbbb");
            //var date = obj.Name;

            var ms = new MYsample();
            //変更不可のオブジェクトなので、add,removeaは新たなインスタンスを返す
            var newList = ms.MyList.Add(6).RemoveAt(0);
            ms.MyList.ForEach(n => Console.Write($"{n}"));
            Console.WriteLine();//改行



            newList.ForEach(n => Console.Write($"{n}"));
            Console.WriteLine();//
            }


            
        }
    }

    class MYsample {
        public ImmutableList <int> MyList { get; private set; }

        public MYsample() {
            var list = new List<int>() { 1, 2, 3, 4, 5 };
            MyList = list.ToImmutableList();
        }
    }

class PasswordPolicy {
        //プロパティの初期化
        public int MinimumLength { get; set; } = 8;



        //読み取り専用プロパティ
        public string GivenName { get; init; } = null;
        public string FamliyName { get; init; } = null;


        //getアクセサーのみを定義した読み取り専用プロパティ
        //public string Name {
           // get { return FamliyName + "" + GivenName; }
        //}

        public string Name => FamliyName + "" + GivenName;
        
        public PasswordPolicy(string familyName, string givenName){
            FamliyName = familyName;
            GivenName = givenName;
        }

       
        }
    

