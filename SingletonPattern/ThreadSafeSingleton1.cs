namespace SingletonPattern
{
    /// <summary>
    /// Enfoque Thread Safe, usado al paralelizar para asegurar que
    /// cada hilo obtiene una unica instancia del tipo
    /// </summary>
    public class ThreadSafeSingleton1
    {

        private static ThreadSafeSingleton1 _instance;
        private static object padLock = new object();

        public static ThreadSafeSingleton1 Instance
        {
            get
            {

                // Solo bloquea la instancia si, la misma es NULL
                // Se conoce como Double-Check Locking Pattern
                if (_instance == null)
                {
                    lock (padLock)
                    {

                        // C# 7
                        if (_instance == null)
                        {
                            _instance = new ThreadSafeSingleton1();
                        }

                    }
                }
                return _instance;
            }
        }

        private ThreadSafeSingleton1() { }
    }
}