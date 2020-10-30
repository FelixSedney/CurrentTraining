using System;
using System.Collections.Generic;
using System.Text;

namespace PersonLibray
{
 public   class Student:Person//overerft van Person
    {
        public string Subject { get; set; }
        public int Grade { get; set; }

        public Student()
        {
        }

        public Student(string firstName, string lastName, int age, string address,string subject,int grade):base(firstName,lastName,age,address)
        {
            //FirstName = firstName;
            Grade = grade;
            Subject = subject;
            
        }

        public override string GetDetails()
        {
            //return base.GetDetails();
            string temp = base.GetDetails();
            return $"{temp}\t{Subject}\t{Grade}";
        }
    }
}
