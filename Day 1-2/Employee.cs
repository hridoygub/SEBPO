using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProject
{
    public class Employee
    {
        public float salary { get; set; } = 40000;
        public virtual void run() { Console.WriteLine("running"); }
    }

    public class Employee2 : Employee 
    {
       public int bonus { get; set; } = 1000;
        public override void run() { Console.WriteLine("running in 60km"); }
    }

    public abstract class Tushi
    {
        public abstract void runs();
    }

    public class Hridoy : Tushi
    {
        public override void runs()
        {
            Console.WriteLine("We aren't made for each other! :) ");
        }
    }

    public interface Drawable
    {
        void draw();
    }
    public class Rectangle : Drawable
    {
        public void draw()
        {
            Console.WriteLine("drawing rectangle...");
        }
    }
    public class Circle : Drawable
    {
        public void draw()
        {
            Console.WriteLine("drawing circle...");
        }
    }
    public class Name
    {
        private string name;

        public string getName() { return name; }

        public void setName(string name) { this.name = name;}
    }
}
