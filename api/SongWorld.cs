using System;
using System.IO;

namespace api
{
    public class SongWorld
    {
        public string Songworld { get; set; }
        public string Songworld2 { get; set; }

        public SongWorld()
        {
            if (File.Exists("Song1.txt"))
            {
                Songworld = File.ReadAllText("Song1.txt");
            }
            else
            {
                Songworld = "??";
            }
            if (File.Exists("Song2.txt"))
            {
                Songworld2 = File.ReadAllText("Song2.txt");
            }
            else
            {
                Songworld2 = "??";
            }
        }
    }
}
