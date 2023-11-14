using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week6_Exercise
{
    internal class Student
    {

        private string name;
        private string surname;
        private int visa1;
        private int visa2;
        private int final;
        private string schoolName;

        public string Name    // property
        {
            get { return name; }
            set { name = value; }
        }
        public string Surname    // property
        {
            get { return surname; }
            set { surname = value; }
        }
        public int Visa1    // property
        {
            get { return visa1; }
            set { visa1 = value; }
        }
        public int Visa2    // property
        {
            get { return visa2; }
            set { visa2 = value; }
        }
        public int Final    // property
        {
            get { return final; }
            set { final = value; }
        }

        public string SchoolName    // property
        {
            get { return schoolName; }
            set { schoolName = value; }
        }

        public int Calculate    // property
        {
            get { return Visa1 + Visa2 + Final / 3; }
            
        }

        public Student() { }
        
       


    }
}
