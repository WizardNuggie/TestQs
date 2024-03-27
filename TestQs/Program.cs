using DataStructure;

namespace TestQs
{
    internal class Program
    {
        public static Node<Number> NumLst(Node<int> lst)
        {
            Node<Number> newLst = new(null);//**
            Node<Number> newLstToRet = newLst;//**
            Number nmbr;
            Node<int> head = lst;
            bool first = true;
            int num = 0;
            int lngth = 0;
            while (head != null)
            {
                if (head.GetValue() != -1)
                {
                    num *= 10;
                    num += head.GetValue();
                    lngth++;
                }
                else if (first)
                {
                    first = false;
                    nmbr = new Number(num, lngth);
                    newLst = new Node<Number>(nmbr);
                    newLstToRet = newLst;//**
                    num = 0;
                    lngth = 0;
                }
                else
                {
                    nmbr = new Number(num, lngth);
                    Node<Number> newNum = new Node<Number>(nmbr);//**
                    newLst.SetNext(newNum);//**
                    newLst = newLst.GetNext();
                    num = 0;
                    lngth = 0;
                }
                head = head.GetNext();
            }
            return newLstToRet;//**
        }
        static void Main(string[] args)
        {
            //int[] arr = { 1, 3, 5, 2, 4, 3, 6, 2, 1, };
            //Console.WriteLine(IsTri(arr));
            //Song s = new Song("Talsi Hamelech", "Talsi", 120);
            //Song s1 = new Song("Oofuk", "Talsi", 180);
            //Song s2 = new Song("Karmonush", "Talsi", 300);
            //Song s3 = new Song("Ro", "Talsi", 240);
            //PlayList p = new PlayList("Achla Bachla");
            //p.AddSong(s);
            //p.AddSong(s1);
            //p.AddSong(s2);
            //p.AddSong(s3);
            //Console.WriteLine(p.DiscLength());
            //PlayList avgP = new PlayList("Avarage Songs");
            //avgP.SetSongs(SongsByLengthCat(p, "short"));
            //Console.WriteLine(avgP.DiscLength());
            //Node<int> lst = new Node<int>(1, new Node<int>(5, new Node<int>(9, new Node<int>(-1, new Node<int>(2, new Node<int>(6, new Node<int>(-1, new Node<int>(8, new Node<int>(-1)))))))));
            //Console.WriteLine(NumLst(lst));
            Kuku k1 = new Kuku(10);
            Kuku k2 = new Kuku(4, 7);
            Console.WriteLine("sum1 = " + k1.Sum());
            Console.WriteLine("dif1 = " + Kuku.GetDif());
            Console.WriteLine("sum2 = " + k2.Sum());
            Console.WriteLine("dif2 = " + Kuku.GetDif());
            Kuku k3 = new Kuku(10, 20);
            Kiki ki1 = new Kiki(1, 2, 3);
            Console.WriteLine("sum = " + ki1.Sum());
            ki1 = k3;
        }
        public static Song[] SongsByLengthCat(PlayList play, string lengthCat)
        {
            Song[] tempSongs = new Song[100];
            foreach (Song s in play.GetSongs())
            {
                if (s != null && s.LengthCatagory() == lengthCat)//**
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
            return sortedSongs;//**
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
        public static bool IsTri(int[] arr)//**
        {
            if (arr.Length % 3 != 0)//**
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