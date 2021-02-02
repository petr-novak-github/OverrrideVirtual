using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// tu metodu kterou chci prekryt, tak tam dam virutal v rodicovi, a tam kde prekryvam, v decku tak tam dam override
// tim dam asi kompilatoru najevo, ze s tim souhlasim s tim prekrytim, v predchodzim prikladu jsem to udelal bez virtual a override a hlasi to warningy v error listu
// asi tak

namespace OverrideModVirtualNew
{
    class Person
    {
        public int age;
        public Person() { }
        public Person(int v)
        {
            age = v;
        }
        public virtual void writeInfo()
        {           //2.krok
            Console.Write("věk:  " + age);
        }
        public void info()
        {                      //
            Console.WriteLine("info: věk:  " + age);//
        }                                         //
    }

    class Employee : Person
    {
        public int salary;
        public Employee() { }
        public Employee(int v, int p)
          : base(v)
        {
            salary = p;
        }
        public override void writeInfo()
        {           //2.krok
            base.writeInfo();
            Console.Write(", salary: " + salary);
        }
    }

    class Student : Person
    {
        public int scholarship;
        public Student(int v, int s)
          : base(v)
        {
            scholarship = s;
        }
        public override void writeInfo()
        {           //2.krok
            base.writeInfo();
            Console.WriteLine(", scholarship: " + scholarship);
            info();                                  //
        }
    }

    class Accountant : Employee
    {
        public Accountant(int v, int p)
          : base(v, p)
        {
        }
        public override void writeInfo()
        {            //2.krok
            base.writeInfo();
            Console.WriteLine();
        }
    }

    class Teacher : Employee
    {
        public int teachingTime;
        public Teacher(int v, int p, int u)
          : base(v, p)
        {
            teachingTime = u;
        }
        public override void writeInfo()
        {            //2.krok
            base.writeInfo();
            Console.WriteLine(", počet úvazkových hodin: " + teachingTime);
        }
    }






    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student(20, 1000);
            s1.writeInfo();
            Accountant e1 = new Accountant(30, 12000);
            e1.writeInfo();
            Teacher u1 = new Teacher(40, 20000, 22);
            u1.writeInfo();


        }
    }
}
