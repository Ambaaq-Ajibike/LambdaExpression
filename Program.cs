using System;
using System.Collections.Generic;
using System.Collections;
namespace Lamba
{
    class Program
    {
        delegate bool Mydelegate(Person person);
        public static void Main(string[] args)
        {
            List<Person> persons = new List<Person>()
            {
                new Person("Adio", "ojuolape", "08716587465"),
                new Person("Sanjo", "Ilorin", "0871658654"),
                new Person("Mulad", "Apat", "087160876565"),
                new Person("Zazuh", "Zeh", "0874657465"),
                new Person("Zinab", "Ade", "087165896535")
            };
            Mydelegate DName = delegate(Person persons)
            {
                return persons.Name.StartsWith('z');
            }
            PrintDName("Name with 4 letters", persons, DName);
        
            //PrintAddress("Address that ends with e letter words", persons, Adres);
        }
        // static bool Adres(Person person)
        // {
        //     return person.Address.EndsWith('e');
        // }
        // static void PrintAddress(string title, List<Person> persons, Mydelegate md)
        // {
        //     System.Console.WriteLine($"++++++++++++++{title}+++++++++++");
        //     foreach (var s in persons)
        //     {
        //         if(md(s))
        //         {
        //             System.Console.WriteLine(s);
        //         }
        //     }
        // }
        // static bool DName(Person person)
        // {
        //     return person.Name.Length == 5;
        // }
        static void PrintDName(string title, List<Person> p, Mydelegate delname)
        {
            foreach (var person in p)
            {
                if (DName(person))
                {
                    System.Console.WriteLine(person);
                }
            }
        }

        
    }
}