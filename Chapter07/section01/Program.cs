namespace section01 {
    internal class Program {
        static void Main(string[] args) {
            var numbers = new List<int> { 9, 7, 5, 4, 2, 5, 4, 0, 4, 1, 0, 4 };

            var books = Books.GetBooks();
            var priceAverage = books.Average(x);
        }
    }
}
