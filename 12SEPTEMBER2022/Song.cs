using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12September
{
    [StereoDisc(SongName = "SitaRam Movie",Language = "Tamil", Lyrics = "Madankarky and Hanu")]
    public class Song
    {


        [StereoDisc(SongName = "Kurumugil", Language = "Tamil", Lyrics = "Madankarky")]
        static public void kurumugilsong()
        {Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("kurumugilgalai sirumulaigalil yaar thoovinar");

        }

        [StereoDisc(SongName = "Hey Ram Oh Sita", Language = "Tamil", Lyrics = "Madankarky")]
        static public void HeyRamsong()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Thanimaiyil unnai naan neengadha urimai vendum tha");
        }
        [StereoDisc(SongName = "Uraiyum Theeyil", Language = "Tamil", Lyrics = "Madankarky")]

        static public void Uraiyumsong()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Uraiyum theeyil malaiyaai vandhu uyirai theenda vandhayoo");
        }

        [StereoDisc(SongName = "Kannukule", Language = "Tamil", Lyrics = "Madankarky")]

        static public void Kankullesong()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("unnadhu vadanam varaidhadho...");
        }

        static void Main(string[] args)
        {
            kurumugilsong();
            HeyRamsong();   
            Uraiyumsong();
            Kankullesong();
            Console.ReadLine();
        }




    }
}
