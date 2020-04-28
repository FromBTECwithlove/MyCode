using System;
using System.Collections.Generic;
using System.Text;

namespace SDLCs3
{
    public class SortPeopleByAge: IComparer<Person>
    {
        public int Compare(Person x, Person y)
        {
            if(x.Age<y.Age)
            {
                return -1;
            }else if(x.Age==y.Age){
                return 0;
            }
            else
            {
                return 1;
            }
        }
    }
}
