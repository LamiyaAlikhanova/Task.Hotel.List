using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    internal class NotAvaibleExpecition:Exception
    {
        public NotAvaibleExpecition(string message) : base(message)
        {

        }
    }
}
