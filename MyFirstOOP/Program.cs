using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstOOP
{
    class Student
    {
        public string name;
        public int age;
        private bool atSchool = false;
        public void showInfo()
        {
            Console.WriteLine(name + " " + age);
        }
        public void toggleAtSchool()
        {
            atSchool = !(atSchool);

        }

    }



    class Program
    {
        static void Main(string[] args)
        {
            Student roald = new Student();
            Student stuart = new Student();
            roald.name = "Roald";
            roald.age = 14;
            stuart.name = "Stuart";
            stuart.age = 16;
            roald.showInfo();
            stuart.showInfo();
            roald.toggleAtSchool();




            
        }
    }
}
