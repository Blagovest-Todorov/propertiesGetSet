using System;

namespace GettersSetters
{
    class Program
    {
        private string name;

        static void Main(string[] args)
        {
            
        }

        public string Name    // property with backing fields- > variable -> name
        {
            get 
            {
                return name.ToUpper();
            }
            set 
            {
                if (!String.IsNullOrEmpty(value))  // (!string.IsNullOrWhiteSpace())
                {
                    name = value;
                }
                else
                {
                    throw new ArgumentException("U must enter a value, and value must be not null");
                }
            }
            // property is a class member , mechanism that allows us to read and write the state of an Object(of private fiels -> variables)
            // property is a special method called accessor, properties are level of control,restriction to a Object state. make Validation
            //get accessor return the value of a private field, set accessor may perform data validation before, 
            //  it assigns the value of the private field!c Properties encapsulate the state of an Object, control access
            // auto-implemented properties, Properties can be read-only, write-only, read-Write
            // read-only--property that implements only get accessor ! , but no set accessor
            // write-only--property that implements only set accessor !, but no get accessor .
            // read -write property -implements both set abd get accessor !

        }
    }
}
