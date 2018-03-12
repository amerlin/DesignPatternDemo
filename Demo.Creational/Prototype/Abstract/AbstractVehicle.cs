using Demo.Creational.Prototype.Interface;
using Demo.Creational.Prototype.Enum;

namespace Demo.Creational.Prototype.Abstract
{
    public class AbstractVehicle: IVehicle
    {
        public IEngine Engine { get; set; }
        public VehicleColour Colour { get; set; }

        public void Paint(VehicleColour colour)
        {
            Colour = colour;
        }

        public AbstractVehicle(IEngine engine): this(engine, VehicleColour.Unpainted)
        {
            
        }

        private AbstractVehicle(IEngine engine, VehicleColour colour)
        {
            Engine = engine;
            Colour = colour;
        }
        
        
        public object Clone()
        {
            return MemberwiseClone();
        }

        public override string ToString()
        {
            return GetType().Name + " " + Engine + " " + Colour;
        }
    }
}
