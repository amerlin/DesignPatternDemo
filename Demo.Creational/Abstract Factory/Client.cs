using System;
using System.Runtime.CompilerServices;
using Demo.Creational.Abstract_Factory.Abstract;
using Demo.Creational.Abstract_Factory.Factory;
using Demo.Creational.Abstract_Factory.Interface;

namespace Demo.Creational.Abstract_Factory
{
    public class Client
    {
        public Client()
        {
            var whatToMake = "car";
            AbstractVehicleFactory factory = null;

            if (whatToMake.Equals("car"))
            {
                factory = new CarFactory();
            }

            if (whatToMake.Equals("van"))
            {
                factory = new VanFactory();
            }

            if (factory == null)
                return;

            var vehicleBody = factory.CreateBody();
            var vehicleChassis = factory.CreateChassis();
            var vehicleGlassware = factory.CreateGlassware();

            Console.WriteLine(vehicleBody.BodyParts);
            Console.WriteLine(vehicleChassis.ChassisParts);
            Console.WriteLine(vehicleGlassware.GlasswareParts);
        }
    }
}
