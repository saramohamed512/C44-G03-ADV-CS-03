using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3_Advanced.HashTable
{
    internal class StringEqualityCompare : IEqualityComparer<string>
    {
        //public new bool Equals(object? x, object? y)
        //{
        //    string? X = x as string;
        //    string? Y = y as string;
        //    return X?.ToLower().Equals(Y?.ToLower()) ?? false;
        //}

        //public int GetHashCode(object obj)
        //{
        //   String? value= obj as String;
        //    return value?.ToLower().GetHashCode() ?? 0;
        //}
        public new bool Equals(string? X, string? Y)
        {
            return X?.ToLower().Equals(Y?.ToLower()) ?? false;
        }

        public int GetHashCode([DisallowNull]string obj)
        {
          return obj?.GetHashCode() ?? 0;
        }
    }
}
