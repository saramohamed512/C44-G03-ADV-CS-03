using Assignment3_Advanced.HashTable;
using System;
using System.Collections;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region HashTable
          
            
            Hashtable PhoneNote = new Hashtable(new StringEqualityCompare()) {
                //{ "Mona",123},
                //{ "Ali", 456},
                //{ "Sara", 789 }

                //using indexer
                ["Mona"]=123,
                ["Ali"]=456,
                ["Sara"]=789
            };

            //PhoneNote.Add("Mona",123);
            //PhoneNote.Add("Ali", 456);
            //PhoneNote.Add("Sara", 789);
            //foreach (object o in PhoneNote) {
            //    Console.WriteLine(o);
            //}
            #region Indexer
            //Console.WriteLine(PhoneNote["Mohamed"]);
            //PhoneNote["Mohamed"] = 244;
            //PhoneNote["Mena"] = 478;

            #endregion
            if (!PhoneNote.Contains("Ali"))
            {
                PhoneNote.Add("ali", 456);
            }
            else
            {
                Console.WriteLine("Key already existed");
            }

            //print specified data =>DictionaryEntry
            foreach (DictionaryEntry entry in PhoneNote)
            {
                Console.WriteLine($"name: {entry.Key} | phone number: {entry.Value}");
            }
            #endregion
        }
    }
}