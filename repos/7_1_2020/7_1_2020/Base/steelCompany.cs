using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_1_2020.Base
{
    class steelCompany: Metals
    {
        string grade;
        public steelCompany(string grade): base("Steel")
        {
            this.grade = grade;
            Console.WriteLine("Grade: "+ grade);
        }
    }
}
