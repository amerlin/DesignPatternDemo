using Demo.Creational.Prototype.Abstract;

namespace Demo.Creational.Prototype.Concrete
{
    public class StandardEngine : AbstractEngine
    {
        public StandardEngine(int size) : base(size, false)
        {
            //not turbo
        }
    }
}