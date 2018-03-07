using Demo.Creational.Factory_Method.Interface;
using Demo.Creational.Factory_Method.Abstract;

namespace Demo.Creational.Factory_Method.Concrete
{
    public class StandardEngine : AbstractEngine
    {
        public StandardEngine(int size) : base(size, false)
        {
            //not turbo
        }
    }
}
