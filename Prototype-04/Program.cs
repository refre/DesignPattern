using System;
using System.Net.Sockets;
using static System.Console;

namespace Prototype_04
{
    public class Person : ICloneable
    {
        public string[] Names;
        public Address Address;

        public Person(string[] names, Address address)
        {
            Names = names;
            Address = address;  
        }

        public override string ToString()
        {
            return $"{nameof(Names)}: {string.Join(" ", Names)}, {nameof(Address)}: {Address}";
        }

        public object Clone()
        {
            return new Person(Names,(Address)Address.Clone());
        }
    }

    public class Address : ICloneable
    {
        public string StreetNames;
        public int HouseNumber;

        public Address(string streetNames, int houseNumber)
        {
            StreetNames = streetNames;
            HouseNumber = houseNumber;  
        }

        public override string ToString()
        {
            return $"{nameof(StreetNames)}: {StreetNames}, {nameof(HouseNumber)}: {HouseNumber}";
        }

        public object Clone()
        {
            return new Address(StreetNames, HouseNumber);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var john = new Person(new string[ ]{"John","Ellis"},new Address("Hasselt",123));
            
            var jane = (Person)john.Clone();
            jane.Address.HouseNumber = 321;

            WriteLine(john);
            WriteLine(jane);

        }
    }
}
