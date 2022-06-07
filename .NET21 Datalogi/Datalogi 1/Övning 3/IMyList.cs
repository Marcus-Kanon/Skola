namespace Övning_3
{
    public interface IMyList<T>
    {
        T Get(int count);
        void Push(T value);
    }
}