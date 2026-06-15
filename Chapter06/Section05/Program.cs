using System.Dynamic;
using System.Text;

namespace Section05 {
    internal class Program {
        static void Main(string[] args) {
            var sd = new StringBuilder();
            foreach (var word in GetWords()) {

                sd.Append(word);
            }

        }
        private static IEnumerable<object> GetWords() {
            return ["Orenge", "Lemon", "strawberry"];
        }
    }
}

