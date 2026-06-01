namespace section02 {
    internal class Program {
        static void Main(string[] args) {
            Dosomething(100);
            Dosomething(100,"エラーです");
            Dosomething(100,"エラーです",5);
        }




        public static void Dosomething(int num,string messge, int retryCount) {
            //仮コード
            Console.WriteLine($"{num} {messge} {retryCount}");
        }
    }
}
