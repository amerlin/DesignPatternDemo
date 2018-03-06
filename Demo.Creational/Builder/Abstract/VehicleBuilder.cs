using Demo.Creational.Builder.Interface;

namespace Demo.Creational.Builder.Abstract
{
    public abstract class VehicleBuilder
    {
        public virtual void BuildBody() { }
        public virtual void BuildBoot() { }
        public virtual void BuildChassis() { }
        public virtual void BuildPassengerArea() { }
        public virtual void BuildReinforcedStorageArea() { }
        public virtual void BuildWindows() { }

        public abstract IVehicle Vehicle { get; }

    }
}
