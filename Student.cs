using System;
using System.Collections.Generic;
using System.Text;

namespace ls1.Class
{
    class Student  : User
    {
        public Student(): base() {
        }
       public Student(string name, int number_of_homework_completed, DateTime date_of_entry) : base(name, date_of_entry)
        {
            Name = name;
            NumberOfHomeworkCompleted = number_of_homework_completed;
            DateOfEntry = date_of_entry;
            Count++;
            Id = Count;
        }
        public override void Print()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Number of homework completed: {NumberOfHomeworkCompleted}");
            Console.WriteLine($"Id: {Id}");
            Console.WriteLine($"Date of entry: {DateOfEntry}");
        }
        public int NumberOfHomeworkCompleted { get; set; }
    }
}
