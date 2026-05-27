
namespace Exercise01 {
    internal class Program {
        static void Main(string[] args) {
            List<string> langs = [
    "C#", "Java", "Ruby", "PHP", "Python", "TypeScript",
                "JavaScript", "Swift", "Go",
            ];
            Exercise1(langs);
            Console.WriteLine("---");
            Exercise2(langs);
            Console.WriteLine("---");
            Exercise3(langs);
        }
        private static void Exercise1(List<string> langs) {
            //foreach文
            foreach (var lage in langs) {
                if(lage.Contains('S'))
                Console.WriteLine(lage);
                //for文で出力
                for (int i = 0; i < langs.Count; i++) {
                    if (langs[i].Contains('S'))
                        Console.WriteLine(langs[i]);
                }
                //while文で出力
                Console.WriteLine("\n");
                int count = 0;
                while (count < langs.Count) {
                    if (langs[count].Contains('S')) ;
                    Console.WriteLine(langs[count]);
                    count++;
                }
            }
        }
        private static void Exercise2(List<string> langs) {
            //LINQを使用する(where)
            var selected = langs.Where(s => s.Contains('S'));
            foreach(var lang in selected) {
                Console.WriteLine(lang);
            }
        }
        private static void Exercise3(List<string> langs) {
            var lang = langs.Find(s => s.Length == 10) ?? "unknown";
            Console.WriteLine(lang);
        }
    }
}
