using System.Text.RegularExpressions;
using TextFileProcessor;

Console.Write("検索したい単語を入力してください: ");
string keyword = Console.ReadLine();

WordCounterProcessor.SearchWord = keyword;

string path = @"C:\Users\infosys\source\repos\OOP2026\Chapter14\Section04\Program.cs";
TextProcessor.Run<WordCounterProcessor>(path);

public class WordCounterProcessor : TextProcessor {

    private int _count = 0;

    public static string SearchWord { get; set; } = "";

    protected override void Intialize(string fname) =>
        _count = 0;

    protected override void Execute(string line) {
        if (!string.IsNullOrEmpty(SearchWord)) {
        
            int countInLine = Regex.Matches(line, Regex.Escape(SearchWord)).Count;
            _count += countInLine;
        }
    }

    protected override void Terminate() =>
        Console.WriteLine("「{0}」は全部で {1} 回出現します", SearchWord, _count);

}