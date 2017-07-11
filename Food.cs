using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APFoodEquals
{
    public enum FoodGroup { Meat, Fruit, Vegetables, Sweets }
    
    //is a reference type
    public class Food
    {
        //== operator overload
        public static bool operator ==(Food x, Food y)
        {
            //calling IEquatable<T> .Equals() (static method) and passing the 2 params
            //because we want the "==" operator do exactly what .Equals method does
            //static object.Equals() Deoes null-checking then calls virtual Equals()
            return object.Equals(x, y);
        }
        
        //same as above
        public static bool operator !=(Food x, Food y)
        {
            //returning opposite of whatever comes after "!"
            return !object.Equals(x, y);
        }

        //overriding teh equals method
        public override bool Equals(object obj)
        {
            //clearly "null" can't be equal to "this instance" so:
            if (obj == null)
                return false;
            //if variables pointto the same instance, they must be equal
            //(no matter what equality does)
            if (ReferenceEquals(obj, this))
                return true;
            //finally, simply checking if the supplied argument equals to this reference:
            if (obj.GetType() != this.GetType())
                return false;
            //the "as" operator is like a cast operation (check MSDN.com)
            Food rhs = obj as Food;
            //simply checks the two fields and returns "true" if both are equal
            return this._name == rhs._name && this._group == rhs._group;
        }

        public override int GetHashCode()
        {
            //XOR (same as in FoodItem.cs)
            return this._name.GetHashCode() ^ this._group.GetHashCode();
        }

        private readonly string _name;
        private readonly FoodGroup _group;

        public string Name { get { return _name; } }
        public FoodGroup Group { get { return _group; } }

        //constructor that sets necessary fields
        public Food(string name, FoodGroup group)
        {
            this._name = name;
            this._group = group;
        }

        //converts an object to its string representation
        //overrided = displays name of food
        public override string ToString()
        {
            return _name;
        }
    }
}
