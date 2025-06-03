using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example
{
    class Person
    {
        public string Name { get; set; }
        public string PersonalID { get; set; }

        public override int GetHashCode()
        {
            return PersonalID.GetHashCode();
        }
        public override bool Equals(object? obj)
        {
            if (obj == null) return false; 
            if(!obj.GetType().Equals(typeof(Person))) return false;
            Person other = obj as Person;
            return PersonalID.Equals(other.PersonalID);
        }
    }
}
