using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M2HW5
{
    public class BusinessException : Exception
    {
        public BusinessException(string mes) : base(mes)
        {
        }
    }
}
