using LibraryApp.Extensions;
using System;

namespace LibraryApp.People
{
    public abstract class Person
    {
        private DateTime _dateOfBirth;
        private string dateOfBirth;
        private int _age;
        public DateWrapper Date = new DateWrapper();
        public string DateOfBirth
        {
            get => dateOfBirth;
            set
            {
                DateTime.TryParse(value, out _dateOfBirth);
                dateOfBirth = value;
            }

        }
        public int Age
        {
            get
            {
                // https://stackoverflow.com/questions/9/how-do-i-calculate-someones-age-based-on-a-datetime-type-birthday
                _age = Date.Today.Year - _dateOfBirth.Year;

                if (_dateOfBirth.Date > Date.Today.AddYears(-_age))
                {
                    _age--;
                }

                return _age;
            }
        }

        public string Name { get; set; }
        public readonly bool isAdmin = false;

        public Person(string name, string dateOfBirth)
        {
            Name = name;
            DateOfBirth = dateOfBirth;
        }

        public void Greeting()
        {
            Console.WriteLine($"Hi {Name}");
        }
    }
}
