using System;
using Demo.Creational.Builder.Abstract;
using Demo.Creational.Builder.Concrete;
using Demo.Creational.Builder.Interface;

namespace Demo.Creational.Builder
{
    public class Sample
    {
        public Sample()
        {
            //Sample for Saloon

            AbstractCar car = new Saloon(new StandardEngine(1300));
            VehicleBuilder builder = new CarBuilder(car);
            VehicleDirector director = new CarDirector();
            IVehicle v = director.Build(builder);
            Console.WriteLine(v);
        }
    }
}
