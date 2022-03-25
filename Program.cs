using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics.Contracts;

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
            Contract.Requires(title != null);
            Contract.Requires(title.Length < 100);



            Random b = new Random();

            this.id = b.Next(10000, 100000);
            this.title = a;
            playCount = 0;

        }

        public void IncreasePlayCount(int a)
        {
            
            try
            {
            if (a >= 10000000) throw new Exception("panjang playcount melebihi batas");
            playCount = playCount + a;
            }
            catch (Exception e)
            {
            Console.WriteLine(e.Message);
            }
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