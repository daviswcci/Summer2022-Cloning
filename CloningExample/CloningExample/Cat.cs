using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloningExample
{
    internal class Cat : ICloneable, IComparable<Cat>, IEquatable<Cat>
    {
        public string Name;
        public int Lives;
        public bool AdditionalToes;
        //public Owner Owner; // reference type. which means it is difficult to clone.

        public Cat()
        {
            Name = "Dez";
            Lives = 9;
            AdditionalToes = false;
        }

        public Cat(string name, int lives, bool additionalToes)
        {
            Name = name;
            Lives = lives;
            AdditionalToes = additionalToes;
        }

        public void Meow()
        {
            Console.WriteLine("Meow!");
        }

        public void Die()
        {
            Lives--;
        }

        public object Clone()
        {
            return new Cat(this.Name, this.Lives, this.AdditionalToes);
        }

        public int CompareTo(Cat? other)
        {
            // return 1 if this is greater than other
            // return 0 if this is equal to other
            // return -1 if this is less than other
            if(this.Lives > other.Lives)
            {
                return 1;
            }
            else if (this.Lives == other.Lives)
            {
                return 0;
            }
            else
            {
                return -1;
            }
        }

        public bool Equals(Cat? other)
        {
            return Lives == other.Lives && Name == other.Name;
        }

        public static bool operator ==(Cat left, Cat right)
        {
            return left.Equals(right);
        }

        public static bool operator !=(Cat left, Cat right)
        {
            return !left.Equals(right);
        }
    }
}
