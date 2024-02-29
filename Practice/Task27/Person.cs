using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task27
{
    public class Person
    {
        public int age = 3;
        public string name = "Yanix";

        public bool CheckIsAdult()

        {
            if (this.age > 18)
            {
                return true;
            }
            return false;
            
        }


    }

}
