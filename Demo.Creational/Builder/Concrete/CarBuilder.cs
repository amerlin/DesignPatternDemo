using System;
using Demo.Creational.Builder.Abstract;
using Demo.Creational.Builder.Interface;

namespace Demo.Creational.Builder.Concrete
{
    public class CarBuilder: VehicleBuilder
    {
        private AbstractCar _carInProgess;

        public CarBuilder(AbstractCar car)
        {
            _carInProgess = car;
        }

        public override void BuildBody()
        {
           Console.WriteLine("build body");
        }

        public override void BuildBoot()
        {
           Console.WriteLine("build boot");
        }

        public override void BuildChassis()
        {
           Console.WriteLine("build chassis");
        }

        public override void BuildPassengerArea()
        {
           Console.WriteLine("build passenger area");
        }

        public override void BuildReinforcedStorageArea()
        {
          Console.WriteLine("build reinforced storage area");
        }

        public override void BuildWindows()
        {
          Console.WriteLine("build windows");
        }


        public override IVehicle Vehicle => _carInProgess;
    }
}
