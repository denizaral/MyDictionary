using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> myDictionary = new MyDictionary<int, string>();
            myDictionary.Add(1997, "Deniz");
            myDictionary.Add(1984, "Engin");
        }
    }
}
