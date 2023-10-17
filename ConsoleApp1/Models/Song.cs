using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    public class Song :Music
    {
        public string SongName { get; set; }

        public Song(string singer, string albumName, int year, string songName)
        {
            Singer = singer;
            AlbumName = albumName;
            Year = year;
            SongName = songName;
        }

        public override void Listen()
        {
            Console.WriteLine($"Mahni: {SongName} - Sanatçı: {Singer}");
        }
    }
}
