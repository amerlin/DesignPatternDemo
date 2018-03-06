using Demo.NoPattern.Abstract;

namespace Demo.NoPattern.Concrete
{
    public class StandardEngine: AbstractEngine
    {
        public StandardEngine(int size) : base(size, false)
        {
            //not turbo
        }
    }
}
