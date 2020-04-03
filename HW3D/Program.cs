using System;
using HW3D;

namespace HW3D
{
    public class Program
    {
        //Generics
        //1. What are the benefits of using a generic class over a generalized class?

            //It helps maximize code reuse, type safety, and performance. 

        static void Main(string[] args)
        {
            //Driver for the implementation of the indexer
            IndexerDemo indexer = new IndexerDemo();
            Console.WriteLine(indexer["mySecretPassword"]);

           
            
        }
    }
    //2. Write an interface with get and set accessors for the integer Count Property.
    interface ICount
    {
        int Count { get; set; }
    }
    //.3 Write a class which implements the previously defined interface. Both accessors should access a _count field. The set accessor should throw an exception.
    public class Counter : ICount
    {
        private int _count;
        public int Count
        {
            get { return _count; }
            set
            {
                if (_count < 0)
                {
                    throw new Exception();
                }
                else
                {
                    _count = value;
                }
            }
        }
    }

    //4. Implement an indexer that takes a string as a parameter and returns true when the string is equal to "mySecretPAssword". Otherwise return false.
    public class IndexerDemo
    {
        private string[] test = new string[] {"one", "two", "mySecretPassword"};

        public bool this[string word] => FoundWord(word);

        private bool FoundWord(string word)
        {
            bool result = false;

            for (int i = 0; i < test.Length; i++)
            {
                if (test[i] == word)
                {
                    result = true;
                }
            }
            return result;
        }

    }





}
