namespace DistanceConveter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 3
                && int.TryParse(args[1], out int start) && int.TryParse(args[2], out int end))
            {


                if (args[0] == "-tom")
                {
                    PrintFeettoMeterList(start, end);
                }
                else if (args[0] == "-tof")
                    PrintMeterToFeetList(start, end);
                else
                {
                    Console.WriteLine("引数数式エラー");
                }
            }
            else
            {
                Console.WriteLine("引数エラー");
            }
            //フィートからメートルへの対応表を出力
            static void PrintFeettoMeterList(int start, int stop)
            {FeetConverter converyer =new FeetConverter();
                for (int feet = start feet <= stop; feet++)
                {
                    double meter = converter.ToMeter(feet);
                    Console.WriteLine($"{feet}ft ={meter:0.0000}m");
                }
            }//メートルからフィートへの対応表を出力
            static void PrintMeterToFeetList(int start, int stop)
            {
                FeetConverter converyer = new FeetConverter();
                for (int meter = start; meter <= stop; meter++)
                {
                    double feet = Converter.FromMeter(meter);
                    Console.WriteLine($"{meter}m ={feet:0.0000}ft");
                }
            }
            //フィートからメートルを求める
            static double FeetToMeter(int feet)
            {
                return feet * 0.3048;
            }
            //メートルからフィートを求める
            static double MeterToFeet(int meter)
            {
                return meter / 0.3048;
            }
        }
    }
}



