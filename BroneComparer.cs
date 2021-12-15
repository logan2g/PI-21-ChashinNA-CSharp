using System.Collections.Generic;

namespace MyLab
{
    public class BroneComparer : IComparer<ITransport>
    {
        public int Compare(ITransport x, ITransport y)
        {
            if (x.GetType().Name != y.GetType().Name)
            {
                return x.GetType().FullName.CompareTo(y.GetType().FullName);
            }
            if (x.GetType() == y.GetType() && x is BroneZenit)
            {
                return ComparerCatamaran((BroneZenit)x, (BroneZenit)y);
            }
            if (x.GetType() == y.GetType() && x is BroneCar)
            {
                return ComparerBoat((BroneCar)x, (BroneCar)y);
            }
            return 0;
        }

        private int ComparerBoat(BroneCar x, BroneCar y)
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

        private int ComparerCatamaran(BroneZenit x, BroneZenit y)
        {
            var res = ComparerBoat(x, y);
            if (res != 0)
            {
                return res;
            }
            if (x.DopColor != y.DopColor)
            {
                return x.DopColor.Name.CompareTo(y.DopColor.Name);
            }
            if (x.Weapon != y.Weapon)
            {
                return x.Weapon.CompareTo(y.Weapon);
            }
            if (x.Head != y.Head)
            {
                return x.Head.CompareTo(y.Head);
            }
            return 0;
        }
    }
}
