using System;
using
System.Collections.Generic
;
using System.Linq;
using System.Text;
using
System.Threading.Tasks;

namespace week7
{
    class Personel
    {
        public int P_id;
        public string name;
        public string s_name;
        public static int salary;


        //public static 
        int Salary { get; set; }


        public Personel(int  id, string name, string s_name) {
            P_id = id;
            this.name = name;
            this.s_name = s_name;
        
        }
        public static int Calculate_salary(int new_salary)
        {
            new_salary *= 100;
            return new_salary;
        }


    }
}
 