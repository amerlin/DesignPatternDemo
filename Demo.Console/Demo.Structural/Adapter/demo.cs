using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Demo.Structural.Adapter.Concrete;
using Demo.Structural.Adapter.Interface;

namespace Demo.Structural.Adapter
{
    public class Demo
    {
        public Demo()
        {
            //normal 
            IList<IEngine> engines = new List<IEngine>
            {
                new StandardEngine(1200),
                new StandardEngine(1300),
                new StandardEngine(1000)
            };



        }

    }
}
