using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Demo.NoPattern.Abstract;

namespace Demo.NoPattern.Concrete
{
    public class StandardEngine: AbstractEngine
    {
        public StandardEngine(int size) : base(size, false)
        {
            //not turbo
        }
    }
}
