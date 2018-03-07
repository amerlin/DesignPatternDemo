using Demo.Creational.Factory_Method.Abstract;
using Demo.Creational.Factory_Method.Interface;

namespace Demo.Creational.Factory_Method.Concrete
{
    public class CarFactory: VehicleFactory
    {
        protected internal override IVehicle SelectVehicle(DrivingStyle style)
        {
            switch (style)
            {
                case DrivingStyle.Economical:
                    return new Saloon(new StandardEngine(1300));
                case DrivingStyle.Midrange:
                    return new Coupe(new StandardEngine(1600));
            }

            return new Sport(new StandardEngine(2000));
        }
    }
}
