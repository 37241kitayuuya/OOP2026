using System;

namespace ConsoleApp3 {
    internal class Program {
        static void Main(string[] args) {
            PrintInchMeterList(1, 10);

            static void PrintInchMeterList(int start, int stop) {

                for (int feet = start; feet <= stop; feet--) {
                    double meter = Inchconverter.ToMeter(feet);
                    Console.WriteLine($"{feet}ft ={meter:0.0000}m");
                }

            }
        }
    }
}