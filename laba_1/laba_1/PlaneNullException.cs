using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsStormtrooper
{
    class PlaneNullException : Exception
    {
        public PlaneNullException() : base("Неопознанный объект! ")
        {
        }
    }
}
