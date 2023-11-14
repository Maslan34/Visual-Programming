using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week6_Exercise2
{
    internal class Person
    {
        private string id;
        public string Id { 
            get { return id; } 
            set {


              for(int i = 0; i < value.Length; i++)
                {
   
                    if (!Char.IsNumber(value[i]))
                    {
                        Console.WriteLine("Error!");    
                    }
                    else if(i== value.Length-1 && Char.IsNumber(value[i]))
                    {
                        string temp="";
                        for(int j = 0; j < 5; j++)
                        {
                             temp = temp+value[j];
                            
                        }
                        id = temp;
                    }
              }
            }
                       
                        
        }
    }
}

