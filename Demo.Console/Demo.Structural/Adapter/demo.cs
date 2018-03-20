using System.Collections.Generic;
using Demo.Structural.Adapter.Adapter;
using Demo.Structural.Adapter.Concrete;
using Demo.Structural.Adapter.Interface;

namespace Demo.Structural.Adapter
{
    public class Demo
    {
        //Demo Adapter
        public Demo()
        {
            //normal 
            IList<IEngine> engines = new List<IEngine>
            {
                new StandardEngine(1200),
                new StandardEngine(1300),
                new StandardEngine(1000),
                new SuperGreenEngineAdapter(new SuperGreenEngine(1000))                 //ADAPTER
            };



        }

    }
}
