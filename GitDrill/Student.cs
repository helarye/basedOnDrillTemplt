using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitDrill
{
    internal class Student
    {
        static int nextID = 0;
        int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public Student() 
        {
            Id=nextID++;
            Name = "NameTotav";
            Description = "DescTotav";
        }
        public Student(string name, string description)
        {
            Id = nextID++;
            Name = name;
            Description = description;
        }
        public void PrintStdDit()
        {
            
            Console.WriteLine(this.Id +". "+this.Name+" "+this.Description);
            //stam1
        }
        public void Stam()
        {
            Console.WriteLine("in commit2 version");
            Console.WriteLine("sura B");
            //stam
        }
    }
}
