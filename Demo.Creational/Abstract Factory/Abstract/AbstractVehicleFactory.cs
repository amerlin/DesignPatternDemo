using Demo.Creational.Abstract_Factory.Interface;

namespace Demo.Creational.Abstract_Factory.Abstract
{
    public abstract class AbstractVehicleFactory
    {
        public abstract IBody CreateBody();
        public abstract IChassis CreateChassis();
        public abstract IGlassware CreateGlassware();
    }
}
