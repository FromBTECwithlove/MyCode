using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_AP.Interface
{
    interface IPath
    {
        void setSize();
        public IPath()
        {
            Console.WriteLine("Size of path.");
        }
        // Error: error CS0526: Interfaces cannot contain constructors
    }
}
