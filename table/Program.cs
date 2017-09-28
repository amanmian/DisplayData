using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.IO;
using System.Xml.Linq;

namespace table
{
    class Student
    {
        public string First { get; set; }
        public string Last { get; set; }
        public int ID { get; set; }
        public string Street { get; set; }
        public string City { get; set; }

    }

    class DataTransformations
    {
        static void Main()
        {
            List<Student> students = new List<Student>()
            {
            new Student {First="Aman",
                Last="Mian",
                ID=111,
                Street="123 Main Street",
                City="Kashipur"},
            new Student {First="Shubham",
                Last="Saurabh",
                ID=112,
                Street="124 Main Street",
                City="Lahore"},
            new Student {First="Praveen",
                Last="Bhatt",
                ID=113,
                Street="125 Main Street",
                City="Lake City"},
            };

            //var res = (from student in students
            //           select student);
           // Console.WriteLine(students.Count);
            foreach (var x in students)
            {
                Console.WriteLine( x.First + " " +   x.Last + " " +  x.Street + " " + x.ID + " "  + x.City);
            }
            Console.ReadKey();

            var flag = true;
            while (flag)
            {
                Console.WriteLine("Enter choice: ");
                Console.WriteLine("1.Add");
                Console.WriteLine("2.Search");
                Console.WriteLine("3.Update First Name");
                Console.WriteLine("4.Update Last Name");
                Console.WriteLine("5.Update City");
                Console.WriteLine("6.Remove");
                Console.WriteLine("7.Display");
                Console.WriteLine("8.Exit");

                int choice = Convert.ToInt32(Console.ReadLine());
            //    int UPDATE = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter the details");
                        Student s = new Student();
                        Console.WriteLine("ENTER FIRST NAME");
                        s.First = (Console.ReadLine());
                        Console.WriteLine("ENTER LAST NAME");
                        s.Last = (Console.ReadLine());
                        Console.WriteLine("ENTER ID");
                        s.ID = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("ENTER STREET");
                        s.Street = (Console.ReadLine());
                        Console.WriteLine("ENTER CITY");
                        s.City = (Console.ReadLine());
                        students.Add(s);
                        break;

                    case 2:
                        Console.WriteLine("Enter id to search the whole tuple: ");
                        var search = Convert.ToInt32(Console.ReadLine());
                        var got = students.Where(sa => sa.ID == search).ToList<Student>();
                        foreach (var g in got)
                        {
                            Console.WriteLine(g.First + " " + g.Last + " " + g.ID + " " + g.Street + " " + g.City);
                        }
                        break;

                    case 3:
                        Console.WriteLine("enter product id to update your details: ");
                        var update = Convert.ToInt32(Console.ReadLine());
                        var up = students.FirstOrDefault(u => u.ID == update);
                        Console.WriteLine("UPDATE FIRST NAME");
                        var q = Console.ReadLine();
                        up.First = q;
                        break;


                    case 4:
                                Console.WriteLine("enter product id to update your details: ");
                                var update1 = Convert.ToInt32(Console.ReadLine());
                                var up1 = students.FirstOrDefault(u => u.ID == update1);

                                Console.WriteLine("UPDATE LAST NAME");
                                var q1 = Console.ReadLine();
                                up1.Last = q1;
                                break;

                           

                   case 5:
                                Console.WriteLine("enter product id to update your details: ");
                                var update2 = Convert.ToInt32(Console.ReadLine());
                                var up2 = students.FirstOrDefault(u => u.ID == update2);

                                Console.WriteLine("UPDATE city");
                                var q2 = Console.ReadLine();
                                up2.City = q2;
                                break;

                    case 6:
                        Console.WriteLine("ENTER ID TO DELETE THE RECORD");
                        var delete = Convert.ToInt32(Console.ReadLine());
                        var del = students.Where(sa => sa.ID == delete).ToList<Student>();
                        foreach(var d in del)
                        {
                            students.Remove(d);
                        }
                        break;

                    case 7:
                        Console.WriteLine("display");
                        foreach(var x1 in students)
                        {
                            Console.WriteLine(x1.First + " " + x1.Last + " " + x1.Street + " " + x1.ID + " " + x1.City);
                        }
                        break;

                    case 8:
                        flag = false;
                        break;

                    default:
                        Console.WriteLine("ENTER CORRECT CHOICE");
                        break;

                }
           }
        }
    }
}