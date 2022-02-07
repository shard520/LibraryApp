using System;

namespace LibraryApp.Extensions
{
    public class DateWrapper 
    {
        public virtual DateTime Today
        {
            get => DateTime.Today;
            set => Today = value;
        }
    }
}