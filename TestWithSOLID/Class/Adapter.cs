using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestWithSOLID.Class.Method;
using TestWithSOLID.Interface;

namespace TestWithSOLID.Class
{
    public class Adapter
    {
        public IEnumerable<double> Segment(List<Point> listpoint)
        {
            return Calculator.СalculationoftheSegment(listpoint);
        }
    }
}
