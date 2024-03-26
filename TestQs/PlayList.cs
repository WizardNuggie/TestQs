using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestQs
{
    public class PlayList
    {
        string name;
        Song[] songs;
        public PlayList(string name)
        {
            this.name = name;
            this.songs = new Song[100];
        }
        public Song[] GetSongs()
        {
            return this.songs;
        }
        public void SetSongs(Song[] songs)
        {
            this.songs = songs;
        }
        public void AddSong(Song s)
        {
            int index = 0;
            foreach (Song song in this.songs)
            {
                if (song == null)
                {
                    index++;
                }
            }
            if (index < this.songs.Length)
            {
                this.songs[this.songs.Length - index] = s;
            }
            else
            {
                Console.WriteLine("Playlist is full. Can not add the requested song");
            }
        }
        public string DiscLength()
        {
            int sum = 0;
            foreach (Song s in this.songs)
            {
                if (s != null)
                    sum += s.GetLength();
            }
            int sec = sum % 60;
            int min = (sum / 60) % 60;
            int hrs = (sum / 60) / 60;
            return $"<{hrs}:{min}:{sec}>";
        }
    }
}
