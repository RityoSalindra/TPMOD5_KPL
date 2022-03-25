using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpmodul5_1302204014
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SayaTubeVideo a = new SayaTubeVideo("Tutorial Design By Contract – [Nuruddin Rityo Salindra]");
            a.PrintVideoDetails();
            a.IncreasePlayCount(2);
            a.PrintVideoDetails();
        }
    }

    public class SayaTubeVideo
    {
        private int id;
        private string title;
        private int playCount;

        public SayaTubeVideo(string a)
        {
            Random b = new Random();

            this.id = b.Next(10000, 100000);
            this.title = a;
            playCount = 0;

        }

        public void IncreasePlayCount(int a)
        {
            playCount += a;
        }

        public void PrintVideoDetails()
        {
            Console.WriteLine("id :" + id);
            Console.WriteLine("Title :" + title);
            Console.WriteLine("PlayCount : " + playCount);
            Console.WriteLine();
        }
    }
}