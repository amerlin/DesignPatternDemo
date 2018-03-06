using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Demo.NoPattern.Enum;
using Demo.NoPattern.Interface;

namespace Demo.NoPattern.Abstract
{
    public abstract class AbstractVehicle: IVehicle
    {
        private IEngine engine;
        private VehicleColour colour;

        public AbstractVehicle(IEngine engine): this(engine, VehicleColour.Unpainted)
        {
            this.engine = engine;
        }

        public AbstractVehicle(IEngine engine, VehicleColour colour)
        {
            this.engine = engine;
            this.colour = colour;
        }

        public virtual IEngine Engine
        {
            get { return engine; }
        }

        public virtual VehicleColour Colour
        {
            get { return colour; }
        }


        public void Paint(VehicleColour colour)
        {
            this.colour = colour;
        }

        public override string ToString()
        {
            return $"{this.GetType().Name} ({engine}/{colour})";
        }


    }
}
