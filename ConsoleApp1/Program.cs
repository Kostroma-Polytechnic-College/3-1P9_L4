using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Bin 
    {
        int max;
        public int now;
        public Bin(int a)
        {
            max = a;
            now = 0;
        }
        public void AddTrash(int ad)
        {
            now += ad;
            if (now >= max)
            {
                ToEat(this);
            }
        }
        public event DelegateToEat ToEat;
        public delegate void DelegateToEat(Bin bin);
    }
    class Homeless
    {
        public void Take(Bin bin1)
        {
            bin1.now -= 5;
            Console.WriteLine("Бомж покушал");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Homeless bomj1 = new Homeless();
            Bin bin1 = new Bin(8);
            bin1.ToEat += bomj1.Take;
            bin1.AddTrash(8);
            Console.ReadKey();
        }
    }
}
