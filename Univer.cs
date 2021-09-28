using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
namespace ls1.Class
{
    class Univer
    {

        public Univer(string univer_name, DateTime date_foundation)
        {
            UniverName = univer_name;
            DateFoundation = date_foundation;
            Count++;
            Id = Count;
        }
        public string UniverName { get; set; }
        public DateTime DateFoundation { get; set; }
        public List<Student> Students { get; set; }
        public List<Teacher> Teachers { get; set; }
        public int Id { get; set ; }
        public static int Count { get; set; }
        public void Print()
        {
            Console.WriteLine("Students: ");
            foreach (var item in Students)
            {
                item.Print();
                
            }
            Console.WriteLine($"Id university: {Id}");
            Console.WriteLine("Teachers: ");
                foreach (var item in Teachers)
                {
                    item.Print();
            }
        }
    }
}
