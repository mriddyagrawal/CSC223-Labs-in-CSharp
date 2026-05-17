namespace Testing;

public static class Utils
{
    public class List<T>
    {
        protected T[] _list;
        protected readonly int DEF_CAPACITY = 10;

        public List()
        {
            _list = new T[DEF_CAPACITY];
        }
    }

    public static IEnumerable<long> Collatz(long num)
    {

        if (num <= 1) yield break;

        while (num != 1)
        {
            yield return num;
            if (num % 2 == 0) num /= 2;
            else num = 3 * num + 1;
        }

        yield return num;

    }

}