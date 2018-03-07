﻿using Demo.Creational.Factory_Method.Interface;
using Demo.Creational.Factory_Method.Enum;


namespace Demo.Creational.Factory_Method.Abstract
{
    public abstract class AbstractVehicle: IVehicle
    {
        private readonly IEngine _engine;
        private VehicleColour _colour;

        protected AbstractVehicle(IEngine engine): this(engine, VehicleColour.Unpainted)
        {
            this._engine = engine;
        }

        protected AbstractVehicle(IEngine engine, VehicleColour colour)
        {
            _engine = engine;
            _colour = colour;
        }

        public virtual IEngine Engine => _engine;

        public virtual VehicleColour Colour => _colour;


        public void Paint(VehicleColour colour)
        {
            this._colour = colour;
        }

        public override string ToString()
        {
            return $"{this.GetType().Name} ({_engine}/{_colour})";
        }


    }
}
