using Assignment3_Advanced;
using Assignment3_Advanced.HashTable;
using Assignment3_Advanced.SortedDictionary;
using System;
using System.Collections;
using System.Linq;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region HashTable


            //Hashtable PhoneNote = new Hashtable(new StringEqualityCompare()) {
            //    //{ "Mona",123},
            //    //{ "Ali", 456},
            //    //{ "Sara", 789 }

            //    //using indexer
            //    ["Mona"]=123,
            //    ["Ali"]=456,
            //    ["Sara"]=789
            //};

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
            //if (!PhoneNote.Contains("Ali"))
            //{
            //    PhoneNote.Add("ali", 456);
            //}
            //else
            //{
            //    Console.WriteLine("Key already existed");
            //}

            ////print specified data =>DictionaryEntry
            //foreach (DictionaryEntry entry in PhoneNote)
            //{
            //    Console.WriteLine($"name: {entry.Key} | phone number: {entry.Value}");
            //}
            #endregion
            #region Generic Collection Dictionary
            //Dictionary<String, int> PhoneNote = new Dictionary<String, int>() {
            //    { "Mona",123},
            //    { "Ali", 456},
            //    { "Sara", 789 }

            //};
            #region Indexer
            //Console.WriteLine(PhoneNote["Ali"]);
            //PhoneNote["Ali"] = 100;

            #endregion
            #region Try to get
            //Console.WriteLine(PhoneNote["Mohamed"]);
            //bool Result =PhoneNote.TryGetValue("Ali", out int Number);
            //Console.WriteLine(Result);

            #endregion
            #region Pass Array To Dictionary
            #region example01
            //KeyValuePair<string, int>[] Array =
            //{
            //    new("osama",123),
            //    new("Ali",124)
            //};
            //PhoneNote= new Dictionary<string, int>(Array,new StringEqualityCompare());
            //PhoneNote.Add("ali", 124);
            #endregion
            #region example02
            //Employee E1 = new Employee(10, "Ali", 1000);
            //Employee E2 = new Employee(20, "Sara", 2000);
            //Employee E3 = new Employee(30, "Adam", 3000);
            //Dictionary<Employee, string> employees = new Dictionary<Employee, string>()
            //{
            //    [E1] = "1st",
            //    [E2] = "2nd",
            //    [E3] = "3rd",
            //};
            //Employee E4 = new Employee(30, "Adam", 3000);
            //employees.Add(E4, "4th");

            //foreach (KeyValuePair<Employee,string> item in employees)
            //{
            //    Console.WriteLine($"name: {item.Key} | phone number: {item.Value}");

            //}

            #endregion
            #endregion

            //foreach (KeyValuePair<String,int> phone in PhoneNote) {
            //     Console.WriteLine($"name: {phone.Key} | phone number: {phone.Value}");
            //}

            #endregion
            #region Generic Collection Sorted Dictionary 
            #region example01
            //SortedDictionary<string, int> PhoneNote = new SortedDictionary<string, int>(new StringCompare()) {
            //        { "Mona",123},
            //        { "Ali", 456},
            //        { "Sara", 789 }

            //};
            //foreach (var phoneNote in PhoneNote) { 
            //    Console.WriteLine(phoneNote);
            //}
            #endregion
            #region example02
            Employee E1 = new Employee(10, "Ali", 1000);
            Employee E2 = new Employee(20, "Sara", 2000);
            Employee E3 = new Employee(30, "Adam", 3000);
            SortedDictionary<Employee, string> sortedEps = new SortedDictionary<Employee, string>() {
                [E1] = "1st",
                [E2] = "2nd",
                [E3] = "3rd",
            };
            foreach (var e in sortedEps) { 
                Console.WriteLine(e.ToString());
            }

            #endregion
            #endregion
        }
    }
}