using System;
using System.Collections.Generic;
using System.Text;

namespace ls1.Class
{
    class Teacher : User
    {
        public Teacher() : base()
        {

        }
        public Teacher(string name, DateTime date_of_entry, string school_subject) : base(name, date_of_entry)
        {
            SchoolSubject = school_subject;
            Count++;
            Id = Count;
        }
        public override void Print()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Id: {Id}");
            Console.WriteLine($"Date of entry: {DateOfEntry}");
            Console.WriteLine($"SchoolSubject:{SchoolSubject}");
        }

        public string SchoolSubject { get; set; }
    }
}
