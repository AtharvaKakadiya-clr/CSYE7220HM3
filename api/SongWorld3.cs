using System;
using System.IO;

namespace api
{
    public class SongWorld3
    {
        public string Songworld3 { get; set; }

        public SongWorld3()
        {
            if (File.Exists("Song3.txt"))
            {
                Songworld3 = File.ReadAllText("Song3.txt");
            }
            else
            {
                Songworld3 = "??";
            }
        }
    }
}
