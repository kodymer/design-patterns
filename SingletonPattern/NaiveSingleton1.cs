namespace SingletonPattern
{
    /// <summary>
    /// Es una clase diseñada para tener una unica instancia
    /// durante todo el ciclo de vida de la app
    /// 
    /// - Debe tener un constructor simple, privado y sin 
    /// parametros
    /// - La clase debe ser Sealed (Sellada)
    /// - Un campo static private tiene una referencia a
    /// la instancia
    /// - Un método static public provee acceso al campo
    /// static private
    /// </summary>
    public sealed class NaiveSingleton1
    {
        private static NaiveSingleton1 _instance;

        public static NaiveSingleton1 Instance {
            get
            {
                // C# 7
                if (_instance == null) {
                    _instance = new NaiveSingleton1(); 
                }

                return _instance;
            }
        }

        private NaiveSingleton1() { }
    }
}