using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Demo.Structural.Adapter.Abstract;

namespace Demo.Structural.Adapter.Adapter
{
    //This is adapter class
    public class SuperGreenEngineAdapter: AbstractEngine
    {
        public SuperGreenEngineAdapter(SuperGreenEngine greenEngine) : base(greenEngine.EngineSize, false)
        {

        }
    }

    //CONVERT TO ABSTRACTENGINE
    public class SuperGreenEngine
    {
        public SuperGreenEngine(int size)
        {
            this.EngineSize = size;
        }

        public int EngineSize { get; set; }
    }
}
