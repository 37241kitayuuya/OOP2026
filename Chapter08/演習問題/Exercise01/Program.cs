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
            //var dict = new Dictionary<char,int>();
            SortedDictionary<char, int> dict = new SortedDictionary<char, int>();
            foreach (char c in text) {
                if (char.IsLetter(c)) // アルファベットのみ対象
                {
                    char ch = char.ToUpper(c); // 大文字・小文字を区別しない

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

        }
    }
}
