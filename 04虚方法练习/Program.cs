using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _04虚方法练习
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee person = new BaoAn();// new Manager();
            person.CheckIn();
            Console.ReadKey();
        }
    }

    class Employee
    {
        public virtual void CheckIn()
        {
            Console.WriteLine("员工9:00签到！！");
        }
    }

    class Manager : Employee
    {
        public override void CheckIn()
        {
            Console.WriteLine("经理8:30签到！");
        }
    }

    class BaoAn : Employee
    {
        public override void CheckIn()
        {
            Console.WriteLine("保安6:00签到！");
        }
    }
}
