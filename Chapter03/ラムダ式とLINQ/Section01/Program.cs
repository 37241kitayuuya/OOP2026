namespace Section01 {
    internal class Program {

        static void Main(string[] args) {
            var cities = new List<string> {
                "Tokyo",
                "New Delhi",
                "Bangkok",
                "London",
                "Paris",
                "Berlin",
                "Canberra",
                "Hong Kong",
            };

            var exists = cities.FindAll(s => 6 <=s.Length && s.Contains('o') &&s.EndsWith('n'));
            exists.ForEach(s => Console.WriteLine(s));

        }
    }
}
