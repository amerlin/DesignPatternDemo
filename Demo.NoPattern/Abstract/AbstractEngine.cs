using Demo.NoPattern.Interface;

namespace Demo.NoPattern.Abstract
{
    public abstract class AbstractEngine: IEngine
    {
        private readonly int _size;

        protected AbstractEngine(int size, bool turbo)
        {
            _size = size;
            Turbo = turbo;
        }

        public virtual int Size => _size;

        public virtual bool Turbo { get; }

        public override string ToString()
        {
            return $"{GetType().Name} ({_size})";
        }
    }
}
