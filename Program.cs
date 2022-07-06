using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{
    public class Student
    {
        int id;
        string name;
        int passmark = 35;

       /* public int showid(int id2)
        {
            if (id2 <= 0)
            {
                Console.WriteLine("cannot be Nagative numberrr");
            }
            else
            {
                id = id2;
            }
        }*/
        public int getmarks()
        {
            return passmark;
        }
       public void setid(int id1)
        {
            if (id1 <= 0) 
            {

                throw new Exception("Id cannot be nagative");
            }
            this.id = id1;
        }
        public int getid()
        {
            return this.id;
        }
        public void setname(string name1)
        {
            if (string.IsNullOrEmpty(name1))
            {
                throw new Exception("Name cannot be null or empty");
            }
            this.name =name1;
        }
        public string getname()
        {
            return string.IsNullOrEmpty(this.name) ? "no name" : this.name;
        }


    }
    internal class Program
    {
       public static void Main(string[] args)
        {
            Student obj = new Student();
            obj.setid(100);
            obj.setname("Rahul");
           Console.WriteLine(obj.getid());
            Console.WriteLine(obj.getname());
            Console.WriteLine(obj.getmarks());
           // Console.WriteLine(obj.showid(-200));
        }
    }
}