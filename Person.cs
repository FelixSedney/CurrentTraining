using System;

namespace PersonLibrary
{
    public class Person
    {
        //private string _firstName;
        //private string _lastName;
        //private string _address;
        //private int _age;

        //public string GetFirstName()
        //{
        //    return _firstName;
        //}

        //public void SetFirstName(string firstName)
        //{
        //    _firstName = $"{firstName.Substring(0, 1).ToUpper()}{firstName.Substring(1).ToLower()}";
        //}

        //public string FirstName
        //{
        //    get { return _firstName; }
        //    set { _firstName = $"{value.Substring(0, 1).ToUpper()}{value.Substring(1).ToLower()}"; }
        //}

        //public string LastName
        //{
        //    get { return _lastName; }
        //    set { _lastName = $"{value.Substring(0, 1).ToUpper()}{value.Substring(1).ToLower()}"; }
        //}

        private string _firstName;

        public string FirstName//Property
        {
            get { return _firstName; }
            set { _firstName = $"{value.Substring(0, 1).ToUpper()}{value.Substring(1).ToLower()}"; }
        }


        private string _lastName;

        public string LastName
        {
            get { return _lastName; }
            set
            {
                _lastName = $"{value.Substring(0, 1).ToUpper()}{value.Substring(1).ToLower()}";
            }
        }


        //public string Address
        //{
        //    get { return _address; }
        //    set { _address = value; }
        //}

        //public int Age
        //{
        //    get { return _age; }
        //    set { _age = value; }
        //}

        public string Address { get; set; }//Property
        public int Age { get; set; }

        //CONSTRUCTOR

        public Person()
        {

        }
        public Person(string firstName,string lastName,string address, int age)
        {
            FirstName = firstName;
            LastName = lastName;
            Address = address;
            Age = age;
        }

        public string GetDetails()
        {
            return $"{FirstName}\t{LastName}\t{Address}\t{Age}";
        }

    }
}

