using System;

namespace HashTable
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Hashtable!!");
            Hash<string, int> hash = new Hash<string, int>(6);
            hash.AddNode("To", 1);
            hash.AddNode("be", 2);
            hash.AddNode("or", 3);
            hash.AddNode("not",4);
            hash.AddNode("To", 1);
            hash.AddNode("be", 2);
            hash.display();
            Console.WriteLine("The frequency of To is {0}", hash.frequency("to"));
        }
    }
}
