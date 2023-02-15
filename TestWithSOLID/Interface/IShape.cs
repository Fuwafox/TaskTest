using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestWithSOLID.Interface;
using TestWithSOLID.Class;

namespace TestTask.Interface
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
