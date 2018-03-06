using Demo.Creational.Abstract_Factory.Interface;

namespace Demo.Creational.Abstract_Factory.Concrete
{
    public class CarBody: IBody
    {
        public virtual string BodyParts => "Body parts for car";
    }
}
