using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SealedDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Child ch = new Child();
            ch.ParentMethod();
            Child2 ch2 = new Child2();
            ch2.ParentMethod();
            Console.ReadKey();
        }
    }
    class Parent
    {
        public Parent()
        {
            Console.WriteLine("This is a parent Class");
        }
        public virtual void ParentMethod() {
            Console.WriteLine("THIS IS A PARENT METHOD ");
        }
            

    }
    sealed class Child : Parent
    {
        public Child()
        {
            Console.WriteLine("This is a Child Class");
        }
        
    }
    //class GrandChild : Child    // Can Not Derive From Sealed Class
    class Child2 : Parent
    {
        sealed public override void ParentMethod()
        {
            Console.WriteLine("THIS IS A SEALED METHOD");
        }
    }
    class GrandChild : Child2
    {
        // public override void ParentMethod() { } // can not override member becasue it is sealed
    }
}
