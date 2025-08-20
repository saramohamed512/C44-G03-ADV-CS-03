using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3_Advanced.HashSet
{
    internal class Series:IEquatable<Series>
    {
  
        public int id { get; set; }
        public string title { get; set; }
        public double price { get; set; }
        public Series(int id, string title, double price)
        {
            this.id = id;
            this.title = title;
            this.price = price;
        }
        public override string ToString() {
            return $"Id: {id}, Title: {title}, Price: {price}";
        }
        public bool Equals(Series? other)
        {
            return
                   id == other.id &&
                   title == other.title &&
                   price == other.price;
        }
        public override int GetHashCode()
        {
            return HashCode.Combine(id, title, price);
        }

    }
}
