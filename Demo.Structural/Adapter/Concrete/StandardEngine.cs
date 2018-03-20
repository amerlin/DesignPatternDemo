using Demo.Structural.Adapter.Abstract;

namespace Demo.Structural.Adapter.Concrete
{
    public class StandardEngine : AbstractEngine
    {
        public StandardEngine(int size) : base(size, false)
        {
            //not turbo
        }
    }
}
