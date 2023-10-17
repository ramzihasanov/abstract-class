using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    public class Podcast:Music
    {
        public string PodcastName { get; set; }

        public Podcast(string singer, string albumName, int year, string podcastName)
        {
            Singer = singer;
            AlbumName = albumName;
            Year = year;
            PodcastName = podcastName;
        }

        public override void Listen()
        {
            Console.WriteLine($"Podcast: {PodcastName} - Sunucu: {Singer}");
        }
    }
}
