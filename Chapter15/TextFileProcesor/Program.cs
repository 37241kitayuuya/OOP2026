namespace TextFileProcessor;
public abstract class TextProcessor {
    public static void Run<T>(string FileName) where T : TextProcessor, new() {
        var Self = new T();
        Self.Process(FileName);
    }

    private void Process(string fileName) {
        Intialize(fileName);
        var lines = File.ReadAllLines(fileName);
        foreach (var line in lines) {
            Execute(line);
        }
        Terminate();
    }

        
    protected virtual void Intialize(String fname) { }
    protected virtual void Execute(string line) { }
    protected virtual void Terminate() { }
}