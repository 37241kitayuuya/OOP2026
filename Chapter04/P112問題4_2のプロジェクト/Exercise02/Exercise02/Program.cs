
using System.Data.SqlTypes;

namespace Exercise02 {
    internal class Program {
        static void Main(string[] args) {
            //Console.WriteLine(" --- 4.2.1 ---");
            Exercise1();
            //Console.WriteLine("\n --- 4.2.2 ---");
            Exercise2();
            //Console.WriteLine("\n --- 4.2.3 ---");
            Exercise3();
        }
        //p89～ｐ90を参考
        private static void Exercise1() {
            //if-else文を使用
            var line = Console.ReadLine();
            if(int.TryParse(line,out var num)){ 
            if (num < 0) {
                Console.WriteLine(num);
            } else if (num < 100){
                Console.WriteLine(num * 2);
            } else if (num < 500)  {
                Console.WriteLine(num * 3);
            }else{
                Console.WriteLine(num);
            }else{
                Console.WriteLine("入力値に誤りがあります");
            }
        }

        private static void Exercise2() {
            //switch文を使用
            var line = Console.ReadLine();
            if (int.TryParse(line, out var num)){
            switch(num){
            case < 0;
                Console.WriteLine(num);
                break;
                
            case < 100;
                Console.WriteLine}(num * 2);
                
              



               
                

        }

        private static void Exercise3() {
            //switch式を使用
            var line = Console.ReadLine();
            if(int.TryParse(line,out var num)){
            var text =num switch}{
                    <0=> num,
                    <100=>num*2,
                    <500=> num*3,
                        => num
        };
                Console.WriteLine(outNum);
    }
}

