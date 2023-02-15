using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestShape.Interface
{
    /// <summary>
    /// Общий интерфейс для фигур
    /// </summary>
    public  interface IShape
    {
        public double Square()
        {
            throw new Exception("");
        }
    }
}
