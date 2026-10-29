// See https://aka.ms/new-console-template for more information

using Exercise03;
using TextFileProcessorDI;

var service = new Take20Service();
var processor = new TextFileprocessor(service);
bool fileName = ("pasa");
processor.Run(Console.ReadLine());
