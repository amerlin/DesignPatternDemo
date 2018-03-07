using Demo.Creational.Factory_Method.Abstract;

namespace Demo.Creational.Factory_Method.Concrete
{
    public class TurboEngine: AbstractEngine
    {
        public TurboEngine(int size) : base(size, true)
        {
            //turbo
        }
    }
}
