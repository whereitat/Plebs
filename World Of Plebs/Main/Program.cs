using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    public class Program
    {
        private String hej;

        public string Hej
        {
            get
            {
                return hej;
            }

            set
            {
                hej = value;
            }
        }

        static void Main(string[] args)
        {
            Program p = new Program();
            p.hej = "här är jag";
            Console.WriteLine(p.hej); //Gustav
            Console.ReadKey();
        }
    }
}
