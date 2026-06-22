namespace Test01_01 {
    public class ScoreCounter {
        private IEnumerable<Student> _score;

        // コンストラクタ
        public ScoreCounter(string filePath) {
            _score = ReadScore(filePath);
        }

        //メソッドの概要：
        private static IEnumerable<Student> ReadScore(string filePath) {
            var students = new List<Student>();
            var lines = File.ReadAllLines(filePath);
            foreach (var line in lines) {
                var items = line.Split(',');//カンマ区切りで分割
                var student = new Student {
                    Name = items[0],
                    Subject = items[1],
                    Score = int.
                    Parse(items[2])
                };
                students.Add(student);
            }
            return students;
        }

        //メソッドの概要：
        public IDictionary<string, int> GetPerStudentScore() {
            var dict = new Dictionary<string, int>();
            foreach (var student in _score) {
                //すでに店舗名が辞書のキーに登録されているか？
                if (dict.ContainsKey(student.Name))
                    //登録されている場合
                    dict[student.Name] += Student.score;//売上を足しこみ
                else
                    //未登録の場合
                    dict[student.Name] = Student.score;//新規に売り上げを登録
            }





            return dict;
        }
    }
}
