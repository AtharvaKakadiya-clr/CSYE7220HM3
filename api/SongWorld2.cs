using System;
using System.IO;

namespace api
{
    public class SongWorld2
    {
        public string Songworld2 { get; set; }

        public SongWorld2()
        {
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
