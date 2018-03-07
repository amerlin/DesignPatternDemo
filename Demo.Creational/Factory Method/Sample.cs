using Demo.Creational.Factory_Method.Abstract;
using Demo.Creational.Factory_Method.Concrete;
using Demo.Creational.Factory_Method.Enum;

namespace Demo.Creational.Factory_Method
{
    public class Sample
    {
        public Sample()
        {
            VehicleFactory carFactory = new CarFactory();
            carFactory.Build(VehicleFactory.DrivingStyle.Economical, VehicleColour.Blue);

            VehicleFactory vanFactory = new VanFactory();
            vanFactory.Build(VehicleFactory.DrivingStyle.Economical, VehicleColour.Silver);


        }

       

    }
}
