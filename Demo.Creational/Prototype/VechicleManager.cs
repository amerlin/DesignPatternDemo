using Demo.Creational.Factory_Method.Concrete;
using Demo.Creational.Prototype.Interface;
using Saloon = Demo.Creational.Prototype.Concrete.Saloon;
using StandardEngine = Demo.Creational.Prototype.Concrete.StandardEngine;

namespace Demo.Creational.Prototype
{
    public class VechicleManager
    {
        private readonly IVehicle saloon;
        private readonly IVehicle coupe;
        private readonly IVehicle sport;
        private readonly IVehicle pickup;
        private readonly IVehicle boxVan;

        public VechicleManager()
        {
            saloon = new Saloon(new StandardEngine(1300));
            //coupe
            //sport
            //boxVan
            //pickup
        }

        public virtual IVehicle CreateSaloon()
        {
            return (IVehicle) saloon.Clone();
        }

        public virtual IVehicle CreateCoupe()
        {
            return (IVehicle) coupe.Clone();
        }

        public virtual IVehicle CreateSport()
        {
            return (IVehicle) sport.Clone();
        }

        public virtual IVehicle CreateBoxVan()
        {
            return (IVehicle) boxVan.Clone();
        }

    }
}
