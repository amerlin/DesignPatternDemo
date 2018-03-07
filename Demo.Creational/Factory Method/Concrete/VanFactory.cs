using Demo.Creational.Factory_Method.Abstract;
using Demo.Creational.Factory_Method.Interface;
using Demo.Creational.Factory_Method.Concrete;

namespace Demo.Creational.Factory_Method.Concrete
{
    public class VanFactory: VehicleFactory
    {
        protected internal override IVehicle SelectVehicle(DrivingStyle style)
        {
            if(style==DrivingStyle.Economical || style==DrivingStyle.Midrange)
                return new Pickup(new StandardEngine(2200));
            return new BoxVan(new TurboEngine(2500));
        }
    }
}
