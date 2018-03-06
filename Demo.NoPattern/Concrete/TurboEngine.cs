using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Demo.NoPattern.Abstract;

namespace Demo.NoPattern.Concrete
{
    public class TurboEngine: AbstractEngine
    {
        public TurboEngine(int size) : base(size, true)
        {
            //turbo
        }
    }
}
