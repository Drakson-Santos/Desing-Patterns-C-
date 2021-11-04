using System;

namespace prototype
{
    public class Person
    {
       public string Name { get; set; }
       public int Age { get; set; }

       public Person ShallowCopy()
       {
           return (Person)this.MemberwiseClone();
       }

        [Obsolete]
        public Person DeepCopy()
       {
           Person person = (Person)this.MemberwiseClone();
           person.Name = String.Copy(this.Name);
           return person;
       }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
