using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp.People
{
    class Librarian : Person
    {
        public new readonly bool isAdmin = true;
        public Librarian(string name, string dateOfBirth) : base(name, dateOfBirth)
        {
        }
    }
}
