using System;
using System.Collections.Generic;
using System.Text;

namespace Collections
{
    public class StudentInfo
    {
        

        private int age;
        public int AGE
        {
            get { return age; }
            set { age = value; }
        }

        private float cgpa;
        public float CGPA
        {
            get { return cgpa; }
            set { cgpa = value; }
        }
        private string name;
        public string NAME
        {
            get { return name; }
            set { name = value; }
        }
        private string email;
        public string EMAIL
        {
            get { return email; }
            set { email = value; }
        }
        private string address;
        public string ADDRESS
        {
            get { return address; }
            set { address = value; }
        }
        
        private string contactNumber;
        public string CONTACTNUMBER
        {
            get { return contactNumber; }
            set { contactNumber = value; }
        }
        public StudentInfo() { }
        public StudentInfo(int age,float cgpa,string name,string email, string address, string contactNumber)
        {
            this.age = age;
            this.cgpa = cgpa;
            this.name = name;
            this.email = email;
            this.address = address;
            this.contactNumber = contactNumber;
        }



    }
}
