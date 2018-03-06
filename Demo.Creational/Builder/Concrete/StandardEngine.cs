using Demo.Creational.Builder.Abstract;

namespace Demo.Creational.Builder.Concrete
{
    public class StandardEngine : AbstractEngine
    {
        public StandardEngine(int size) : base(size, false)
        {
            //not turbo
        }
    }
}
