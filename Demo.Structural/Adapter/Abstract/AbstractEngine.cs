using Demo.Structural.Adapter.Interface;

namespace Demo.Structural.Adapter.Abstract
{
    public abstract class AbstractEngine: IEngine
    {
        public virtual int Size { get; }

        public virtual bool Turbo { get; }

        protected AbstractEngine(int size, bool turbo)
        {
            Size = size;
            Turbo = turbo;
        }

        public override string ToString()
        {
            return GetType().Name + this.Size;
        }
    }
}
