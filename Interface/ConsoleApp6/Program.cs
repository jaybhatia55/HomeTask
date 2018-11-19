using System;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            Person Tom = new Person();
            Tom.Walk("tom");
            Tom.Talk("tom");
            Tom.Talk("Human");
            ILivingBeing mukesh = new Person();
            mukesh.Voice("Mukesh, Human");
            Crow crow=new Crow();
            crow.Walk("jackCrow");
            crow.Fly("jackCrow");
            crow.Voice("Crow");
            Console.ReadKey();
        }
    }
    interface ILivingBeing
    {
        void Walk(string name);
        void Voice(string name);
    }
    interface IBird
    {
        void Fly(string name);
        void Voice(string name);
    }
    interface IHuman
    {
        void Talk(string name);
        void Voice(string name);
    }
    public class Person: ILivingBeing,IHuman
    {
        public void Walk(string name)
        {
            Console.WriteLine("I am {0} and i can Walk", name);
        }
        public void Talk(string name)
        {
            Console.WriteLine("I am {0} and i can talk", name);
        }
        public void Voice(string Type)
        {
            Console.WriteLine("I am {0} and i have multiple Voice and speach ", Type);
        }
        void ILivingBeing.Voice(string Type)
        {
            Console.WriteLine("I am {0} and i am the only leaving being with multiple Voice and speach ", Type);
        }
    }
    public class Crow : ILivingBeing, IBird
    {
        public void Walk(string name)
        {
            Console.WriteLine("I am {0} and i can Walk", name);
        }
        public void Fly(string name)
        {
            Console.WriteLine("I am {0} and i can Fly", name);
        }
        public void Voice(string Type)
        {
            Console.WriteLine("I am {0} and my Voice is kaw kaw ", Type);
        }
    }

}
