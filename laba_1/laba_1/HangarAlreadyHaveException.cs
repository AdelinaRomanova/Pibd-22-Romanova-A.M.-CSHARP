using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsStormtrooper
{
    class HangarAlreadyHaveException : Exception
    {
        public HangarAlreadyHaveException() : base("В ангаре уже есть такой самолёт!")
        { }
    }
}
