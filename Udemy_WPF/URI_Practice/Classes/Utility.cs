using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URI_Practice.Classes
{
    public class Student
    {
        private string name;
        private int age;
        private Uri uri;

        public Student(string StudentName, int StudentAge, Uri StudentUri)
        {
            name = StudentName;
            age = StudentAge;
            uri = StudentUri;
        }

        public void DisplayInformation()
        {
            Console.WriteLine(String.Format("Name : {0}", name));
            Console.WriteLine(String.Format("Age : {0}", age));
            Console.WriteLine(String.Format("Uri : {0}", uri));
            Console.WriteLine(uri.Authority);
            Console.WriteLine(uri.Host);
            Console.WriteLine(uri.Port);
            Console.WriteLine(uri.PathAndQuery);
            Console.WriteLine(uri.Scheme);
        }

    }
}
