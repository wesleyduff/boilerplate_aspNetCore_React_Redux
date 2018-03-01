namespace Client.AbstractClasses
{
    public abstract class Crud<T>
    {
        public abstract T Add(T item);
        public abstract T Delete(T item);
        public abstract T Get(T item);
        public abstract T Update(T item);
    }
}
