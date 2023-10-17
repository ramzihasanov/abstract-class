using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    public abstract class Music
    {
        public string Singer { get; set; }
        public string AlbumName { get; set; }
        public int Year { get; set; }

        public abstract void Listen();
    }
}

