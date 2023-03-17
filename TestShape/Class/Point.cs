using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using TestShape.Interface;

namespace TestShape.Class
{
    /// <summary>
    /// Класс точек
    /// </summary>
    public class Point:IEquatable<Point>
    {
        public double X { get; set; }
        public double Y { get; set; }
        public bool Equals(Point other)
        {
            if (Object.ReferenceEquals(other, null)) return false;
            if (Object.ReferenceEquals(this, other)) return true;
            return X.Equals(other.X) && Y.Equals(other.Y);
        }

        public override int GetHashCode()
        {
            return X == null ? 0 : X.GetHashCode() ^ Y.GetHashCode();
        }

    }
}
