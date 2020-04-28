using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class ExList<T>
    {
      public void add(T input) { }
    }
    class testProgram
    {
        private class listItem { }
        static void Main(string []args)
        {
            ExList<int> ExList1 = new ExList<int>();
            ExList1.add(1);
            ExList<string> ExList2 = new ExList<string>();
            ExList2.add("I'm Huan");
            ExList<listItem> ExList3 = new ExList<listItem>();
            ExList3.add(new listItem());
        }
    }
}
