using System;
using Demo.Creational.Abstract_Factory.Abstract;
using Demo.Creational.Abstract_Factory.Concrete;
using Demo.Creational.Abstract_Factory.Interface;

namespace Demo.Creational.Abstract_Factory.Factory
{
    public class CarFactory: AbstractVehicleFactory
    {
        public override IBody CreateBody()
        {
            return new CarBody();
        }

        public override IChassis CreateChassis()
        {
            return new CarChassis();
        }

        public override IGlassware CreateGlassware()
        {
            return new CarGlassware();
        }
    }
}
