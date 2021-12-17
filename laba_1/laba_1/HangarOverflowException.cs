using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsStormtrooper 
{
    class HangarOverflowException : Exception
    {
        public HangarOverflowException() : base("На парковке нет свободных мест")
        { }
    }
}
