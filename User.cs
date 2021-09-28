using System;
using System.Collections.Generic;
using System.Text;

namespace ls1.Class
{
    abstract class User
    {
        public User()
        {
            Count++;
            Id = Count;
        }
        public User(string name, DateTime date_of_entry)
        {
            Name = name;
            DateOfEntry = date_of_entry;
            Count++;
            Id = Count;
        }
        public abstract void Print();
        public string Name { get; set; }
        public DateTime DateOfEntry { get; set; }
        public int Id { get; set; }
        public static int Count { get; set; }
    }
}
