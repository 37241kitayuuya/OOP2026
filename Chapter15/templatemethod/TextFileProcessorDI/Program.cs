using TextFileProcessorDI;

var service = new LineCounterService();
var processor = new TextFileprocessor(service);
string fileName =("パスの入力:");
    processor.Run(Console.ReadLine());