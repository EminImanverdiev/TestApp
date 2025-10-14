using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp.Models
{
      class Person
    {
        public int Id { get; set; }
        public string Name;
        public string Surname;
        public int Age;
        public DateTime BirthDate;
        public Person(string name,string surname,int age)
        {
            Name=name;
            Surname=surname;
            Age=age;

        }
        public string ShowInfo()
        {
            return $"Name: {Name}, Surname: {Surname}, Age: {Age}";
        }
    }
}
