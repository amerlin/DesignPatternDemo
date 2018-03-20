namespace Demo.Creational.Singleton
{
    public class SerialNumberGenerator
    {
        //Volatile = set by multithread
        private static volatile SerialNumberGenerator _instance;

        public static SerialNumberGenerator Instance => _instance ?? (_instance = new SerialNumberGenerator());

        //instance number
        private int _count;

        //private costructor
        private SerialNumberGenerator()
        {

        }
        public virtual int NextSerial => ++_count;
    }
}
