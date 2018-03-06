using Demo.Creational.Abstract_Factory.Interface;

namespace Demo.Creational.Abstract_Factory.Concrete
{
    public class VanChassis: IChassis
    {
        public virtual string ChassisParts => "Chassis parts for a van";
    }
}
