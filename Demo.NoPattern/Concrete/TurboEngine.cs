using Demo.NoPattern.Abstract;

namespace Demo.NoPattern.Concrete
{
    public class TurboEngine: AbstractEngine
    {
        public TurboEngine(int size) : base(size, true)
        {
            //turbo
        }
    }
}
