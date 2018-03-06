using System;
using Demo.Creational.Abstract_Factory.Abstract;
using Demo.Creational.Abstract_Factory.Concrete;
using Demo.Creational.Abstract_Factory.Interface;

namespace Demo.Creational.Abstract_Factory.Factory
{
    public class VanFactory: AbstractVehicleFactory
    {
        public override IBody CreateBody()
        {
           return new VanBody();
        }

        public override IChassis CreateChassis()
        {
           return new VanChassis();
        }

        public override IGlassware CreateGlassware()
        {
            return new VanGlassware();
        }
    }
}
