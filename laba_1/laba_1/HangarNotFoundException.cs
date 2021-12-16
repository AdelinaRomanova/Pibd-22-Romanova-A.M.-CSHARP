using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsStormtrooper 
{
    class HangarNotFoundException : Exception
    {
        public HangarNotFoundException(int i) : base("Не найден автомобиль по месту " + i)
        {
        }
    }
}
