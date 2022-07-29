using System;
namespace Lamba
{
    public class Person
    {
        public string Name{get; set;}
        public string Address{get; set;}
        public string PhoneNumber{get; set;}
        public Person(string name, string address, string phonenumber)
        {
            Name = name;
            Address = address;
            PhoneNumber = phonenumber;
        }
        public override string ToString()
        {
            return $"Name: {Name}\n Address: {Address}\n PhoneNumber: {PhoneNumber}";
        }
    }
}