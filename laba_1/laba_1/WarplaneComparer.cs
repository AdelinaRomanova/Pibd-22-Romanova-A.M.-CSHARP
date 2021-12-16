using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsStormtrooper
{
    class WarplaneComparer : IComparer<Vehicle>
    {
        public int Compare(Vehicle x, Vehicle y)
        {
            if (x.GetType() != y.GetType())
            {
                if (x is Warplane && y is Stormtrooper) 
                    return -1;
                else 
                    return 1;
            }

            if (x.GetType().Name.Equals("Warplane")) return ComparerWarplane((Warplane)x, (Warplane)y);
            if (x.GetType().Name.Equals("Stormtrooper")) return ComparerStormtrooper((Stormtrooper)x, (Stormtrooper)y);

            return 0;
        }

        private int ComparerWarplane(Warplane x, Warplane y)
        {
            if (x.MaxSpeed != y.MaxSpeed)
            {
                return x.MaxSpeed.CompareTo(y.MaxSpeed);
            }
            if (x.Weight != y.Weight)
            {
                return x.Weight.CompareTo(y.Weight);
            }
            if (x.MainColor != y.MainColor)
            {
                return x.MainColor.Name.CompareTo(y.MainColor.Name);
            }
            return 0;
        }

        private int ComparerStormtrooper(Stormtrooper x, Stormtrooper y)
        {
            var res = ComparerWarplane(x, y);
            if (res != 0)
            {
                return res;
            }
            if (x.DopColor != y.DopColor)
            {
                return x.DopColor.Name.CompareTo(y.DopColor.Name);
            }
            if (x.Gun != y.Gun)
            {
                return x.Gun.CompareTo(y.Gun);
            }
            if (x.Turbo != y.Turbo)
            {
                return x.Turbo.CompareTo(y.Turbo);
            }
            return 0;
        }
    }
}
