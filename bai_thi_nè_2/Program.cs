using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai_thi_nè_2
{
    class Animal
    {
        protected double weight;
        protected string name;

        public void SetMe(double weight, string name)
        {
            this.weight = weight;
            this.name = name;
        }

        public virtual void Show()
        {
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Weight: {weight} kg");
        }
    }

    class tiger : Animal
    {
        public tiger(double weight, string name)
        {
            base.SetMe(weight, name);
        }
    }

    class lion : Animal
    {
        public lion(double weight, string name)
        {
            base.SetMe(weight, name);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            tiger Tiger = new tiger(200, "Tiger");
            lion Lion = new lion(180, "Lion");

            Tiger.Show();
            Console.WriteLine();S

            Lion.Show();
            Console.WriteLine();
        }
    }
}
