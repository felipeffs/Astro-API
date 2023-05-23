namespace Atv1Astrologia.Helpers
{
    public abstract class Singleton<T> where T : class, new()
    {
        private static readonly Lazy<T> _instance = new Lazy<T>(() => new T());

        public static T Instance { get { return _instance.Value; } }

        protected Singleton()
        {
            SingletonAwake();
        }

        protected virtual void SingletonAwake() { }

    }
}
