namespace TestQs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[] arr = { 1, 3, 5, 2, 4, 3, 6, 2, 1, };
            //Console.WriteLine(IsTri(arr));
            Song s = new Song("Talsi Hamelech", "Talsi", 120);
            Song s1 = new Song("Oofuk", "Talsi", 180);
            Song s2 = new Song("Karmonush", "Talsi", 300);
            Song s3 = new Song("RO", "Talsi", 240);
            PlayList p = new PlayList("Achla Bachla");
            p.AddSong(s);
            p.AddSong(s1);
            p.AddSong(s2);
            p.AddSong(s3);
            Console.WriteLine(p.DiscLength());
            PlayList avgP = new PlayList("Avarage Songs");
            avgP.SetSongs(SongsByLengthCat(p, "short"));
            Console.WriteLine(avgP.DiscLength());
        }
        public static Song[] SongsByLengthCat(PlayList play, string lengthCat)
        {
            Song[] tempSongs = new Song[100];
            foreach (Song s in play.GetSongs())
            {
                if (s != null && s.LengthCatagory() == lengthCat)
                    AddSong(tempSongs, s);
            }
            int length = 0;
            foreach (Song s in tempSongs)
            {
                if (s != null)
                    length++;
            }
            Song[] sortedSongs = new Song[length];
            foreach (Song s in tempSongs)
            {
                if (s != null)
                    AddSong(sortedSongs, s);
            }
            return sortedSongs;
        }
        public static void AddSong(Song[] songs, Song s)
        {
            bool added = false;
            for (int i = 0; i < songs.Length; i++)
            {
                if (songs[i] == null && !added)
                {
                    songs[i] = s;
                    added = true;
                }
            }
        }
        public static bool IsTri(int[] arr)
        {
            if (arr.Length % 3 != 0)
            {
                return false;
            }
            int sum = arr[0] + arr[1] + arr[2];
            int sum2 = sum;
            if (arr.Length == 3)
            {
                return true;
            }
            for (int i = 3; i < arr.Length; i++)
            {
                if (i % 3 == 0)
                {
                    sum = arr[i] + arr[i + 1] + arr[i + 2];
                    if (sum == sum2)
                        return true;
                }
            }
            return false;
        }
    }
}