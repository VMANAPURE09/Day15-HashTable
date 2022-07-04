using System;

namespace DataStructure
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("HashTable Program- ");

            MyMapNode<string, string> hash = new MyMapNode<string, string>(19);
            hash.Add("0", "Paranoids");
            hash.Add("1", "are");
            hash.Add("2", "not");
            hash.Add("3", "paranoid");
            hash.Add("4", "because");
            hash.Add("5", "they");
            hash.Add("6", "are");
            hash.Add("7", "paranoid");
            hash.Add("8", "but");
            hash.Add("9", "because");
            hash.Add("10", "they");
            hash.Add("11", "keep");
            hash.Add("12", "putting");
            hash.Add("13", "themselves");
            hash.Add("14", "deliberately");
            hash.Add("15", "into");
            hash.Add("16", "paranoid");
            hash.Add("17", "avoidable");
            hash.Add("18", "situations");


            string hash1 = hash.Get("12");
            Console.WriteLine("12th Index Value is :" + hash1);


            string hash2 = hash.Get("16");
            Console.WriteLine("16th Index Value is :" + hash2);
        }
    }
}
