List<IGreetinBase> list = [
    new GreetingMorning(),
    new GreetingAfternoon(),
    new GreetingEvening(),
    ];

foreach (var obj in list) {
    string msg = obj.GetMessage();
    Console.WriteLine(msg);
}
//インターフェイス
interface IGreetinBase {
     string GetMessage() => "";
}
//IGreetingBaseを実装したクラス
class GreetingMorning : IGreetinBase {
    public  string GetMessage() => "おはよう";
}

class GreetingAfternoon : IGreetinBase {
    public  string GetMessage() => "こんにちは";
}

class GreetingEvening : IGreetinBase {
    public  string GetMessage() => "こんばんは";
}
