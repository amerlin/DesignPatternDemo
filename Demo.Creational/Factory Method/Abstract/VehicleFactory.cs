using Demo.Creational.Factory_Method.Interface;
using Demo.Creational.Factory_Method.Enum;

namespace Demo.Creational.Factory_Method.Abstract
{
    public  abstract class VehicleFactory
    {
        public enum DrivingStyle
        {
            Economical, Midrange, Powerful
        }

        public virtual IVehicle Build(DrivingStyle style, VehicleColour colour)
        {
            var v = SelectVehicle(style);
            v.Paint(colour);
            return v;
        }

        protected internal abstract IVehicle SelectVehicle(DrivingStyle style);
    }
}
