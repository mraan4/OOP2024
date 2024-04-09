using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q3
{
    internal class Program
    {
        class Song
        {
            private string title;
            private string artist;
            private int year;
            private string country;

            public Song()
            {
                this.title = "title";
                this.artist = "artist";
                this.year = 0000;
                this.country = "country";
            }

            public Song(string title, string artist, int year, string country)
            {
                this.title = title;
                this.artist = artist;
                this.year = year;
                this.country = country;
            }

            public void Show()
            {
                Console.WriteLine(year + "년 " + country + "국적의 " + artist + "가 부른 " + title);
            }
        }
        static void Main(string[] args)
        {
            Song song = new Song("Dancing Queen", "ABBA", 1978, "스웨덴");
            song.Show();
        }
    }
}
