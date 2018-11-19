using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Worker Guard = new Worker();
            Guard.name = "rohit";
            Guard.SalaryCounter(0,0);
            Guard.Display();
            Console.ReadKey();
        }
    }
    public abstract class SalaryDepartment
    {
        public int Salary = 0, TotalHours = 0, PerHour = 100, FixTime = 8;
        public string name;
        public abstract void Display();
        public void SalaryCounter(int Bonus,int OverTime)
        {
            Salary = PerHour * FixTime;
            TotalHours = OverTime + FixTime;
            if(TotalHours>FixTime)
            {
                OverTime = TotalHours - FixTime;
                Salary = Salary + (PerHour * TotalHours);
            }
            Salary = Salary + Bonus;
            Console.WriteLine("bonus   :{0} \ntotalHours   :{1}",Bonus,TotalHours);
        }

    }
    class Worker : SalaryDepartment
    {
        public override void Display()
        {
            Console.WriteLine("\n-------------------------------\nName :{0} \nfix time: {1}\nperhour: {2}\n-----------------------------\nTotal Salary of {3} : {4}", name, FixTime, PerHour, name, Salary);

        }
    }
}
