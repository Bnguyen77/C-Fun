using System;

namespace classes1
{
    public class Person
    {
        public string firstName;
        public string lastName;

        public void introduce()
        {
            Console.WriteLine("my name is " + firstName + " " + lastName);
        }
    }
}
