using System;

namespace PersonLibray
{
    public   class Person//mogelijkheden zijn ABSTRACT, STATIC en SEALED
    {
        private string _firstName;

        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = $"{value.Substring(0,1).ToUpper()}{value.Substring(1).ToLower()}"; }
        }

        private string _lastName;

        public string LastName
        {
            get { return _lastName; }
            set { _lastName = $"{value.Substring(0, 1).ToUpper()}{value.Substring(1).ToLower()}"; }
        }
        public int Age { get; set; }
        public string Address { get; set; }

        public Person() { }

        public Person(string firstName,string lastName,int age, string address)
        {
            FirstName = firstName;
            LastName = lastName;
            Address = address;
            Age = age;
        }

        public virtual string GetDetails()
        {
            return $"{FirstName}\t{LastName}\t{Address}\t{Age}";
        }

        public override string ToString()
        {
            //return base.ToString();
            return $"{FirstName}\t{LastName}\t{Address}\t{Age}";
        }

    }
}
