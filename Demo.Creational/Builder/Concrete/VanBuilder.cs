using System;
using Demo.Creational.Builder.Abstract;
using Demo.Creational.Builder.Interface;

namespace Demo.Creational.Builder.Concrete
{
    public class VanBuilder: VehicleBuilder
    {
        private AbstractVan _vanInProgress;

        public VanBuilder(AbstractVan van)
        {
            _vanInProgress = van;
        }

        public override void BuildBody()
        {
            Console.WriteLine("build body");
        }

        //Not for this car types 
        //public override void BuildBoot()
        //{
        //    Console.WriteLine("build boot");
        //}

        public override void BuildChassis()
        {
            Console.WriteLine("build chassis");
        }

        public override void BuildReinforcedStorageArea()
        {
            Console.WriteLine("build passenger area");
        }

        //Not for this car types 
        //public override void BuildPassengerArea()
        //{
        //    Console.WriteLine("build reinforced storage area");
        //}

        public override void BuildWindows()
        {
            Console.WriteLine("build windows");
        }


        public override IVehicle Vehicle { get; }
    }
}
