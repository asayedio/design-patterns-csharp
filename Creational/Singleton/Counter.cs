namespace DesignPatterns.Creational.Singleton
{
    public class Counter
    {
        public int count = 0;
        private static Counter instance = null;

        private Counter() { }

        public static Counter GetInstance()
        {
            if (instance is null) instance = new Counter(); // Lazy Initialization
            return instance;
        }
        public void AddOne() => count++;
    }
}
