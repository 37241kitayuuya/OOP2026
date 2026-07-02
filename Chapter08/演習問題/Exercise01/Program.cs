namespace Exercise01 {
    internal class Program {
        private static object count;

        static void Main(string[] args) {
            var text = "Cozy lummox gives smart squid who asks for job pen";

            Exercise1(text);
            Console.WriteLine();
            Exercise2(text);
        }

        private static void Exercise1(string text) {
            var dict = new Dictionary<char,int>();
            foreach (char ch in text.ToUpper() ){
                if ('A' <= ch && ch <= 'Z') // アルファベットのみ対象
                {
                    if (dict.ContainsKey(ch))
                        dict[ch]++;
                    else
                        dict[ch] = 1;
                }
            }

            foreach (var item in dict.OrderBy(x =>x.Key)) {
                Console.WriteLine($"{item.Key} : {item.Value}");
            }

        }

        private static void Exercise2(string text) {
            SortedDictionary<char, int> dict = new SortedDictionary<char, int>();
            foreach (char ch in text.ToUpper()) {
                if ('A' <= ch && ch <= 'Z') // アルファベットのみ対象
                {
                    if (dict.ContainsKey(ch))
                        dict[ch]++;
                    else
                        dict[ch] = 1;
                }
            }

            foreach (var item in dict.OrderBy(x => x.Key)) {
                Console.WriteLine($"{item.Key} : {item.Value}");
            }

        }

    }
    }
}
