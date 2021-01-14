using System;

namespace Property_indexes
{
    public class Person
    {
        public string Name { get; set; }
        public DateTime Birthdate { get; private set; }
        public Person(DateTime birtdate)
        {
            Birthdate = birtdate;
        }
        
        public int Age
        {
            get
            {
                var timeSpan = DateTime.Today - Birthdate;
                return timeSpan.Days/365;
            }
        }
    }
}
