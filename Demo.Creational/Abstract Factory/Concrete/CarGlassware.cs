using Demo.Creational.Abstract_Factory.Interface;

namespace Demo.Creational.Abstract_Factory.Concrete
{
    public class CarGlassware: IGlassware
    {
        public virtual string GlasswareParts
        {
            get { return "Window glassware for a car"; }
        }
    }
}
