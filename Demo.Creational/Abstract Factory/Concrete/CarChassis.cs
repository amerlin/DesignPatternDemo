using Demo.Creational.Abstract_Factory.Interface;

namespace Demo.Creational.Abstract_Factory.Concrete
{
    public class CarChassis: IChassis
    {
        public virtual string ChassisParts => "Chassis parts for a car";
    }
}
