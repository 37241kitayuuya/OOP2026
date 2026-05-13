
namespace Exercise01 {
    internal class Program {
        static void Main(string[] args) {


            var songs = new List<Song>();

            Console.Write("曲名");
            string? title = Console.ReadLine(); 
            Console.Write("アーティスト名:");
            string? artistname = Console.ReadLine();
            Console.Write("演奏時間：");
            int length =int.Parse  (Console.ReadLine());
            
            


            Song song = new Song(title, artistname, length);

            songs.Add(song);
            PrintSongs(songs);


            //2.1.3
            /*var songs = new Song[] {
                new Song("Let it be", "The Beatles", 243),
                new Song("Bridge Over Troubled Water", "Simon & Garfunkel", 293),
                new Song("Close To You", "Carpenters", 276),
                new Song("Honesty", "Billy Joel", 231),
                new Song("I Will Always Love You", "Whitney Houston", 273),
                

            };*/
            PrintSongs(songs);
        }
        private static void PrintSongs(IEnumerable<Song> songs) {
            foreach(var song in songs) {
                var minutes = song.Length / 60;
                var seconds = song.Length % 60;
                Console.WriteLine($"{song.Title},{song.ArtistName}{minutes}:{seconds:00}");
            }
        }
    }
}