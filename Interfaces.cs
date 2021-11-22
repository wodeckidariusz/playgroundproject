using System;

namespace PlaygroundProject
{
    public interface ICustomEnumerator
    {
        object Current { get; }
        void Reset();
    }

    public interface ICustomUpEnumerator : ICustomEnumerator
    {
        bool MoveNext();
    }

    public interface ICustomDownEnumerator : ICustomEnumerator
    {
        bool MovePrevious();
    }

    internal class Counter : ICustomEnumerator
    {
        public int _count, _limit;

        public Counter(int count, int limit)
        {
            _count = count;
            _limit = limit;
        }

        public object Current { get { return _count; } }

        public void Reset()
        {
            _count = 0;
            _limit = 0;
        }

    }

    internal class DownCounter : Counter, ICustomEnumerator, ICustomDownEnumerator
    {
        public DownCounter(int _count, int _limit) : base(_count, _limit)
        {

        }

        public bool MovePrevious()
        {
            return --_count > _limit;
        }

    }

    internal class UpCounter : Counter, ICustomEnumerator, ICustomUpEnumerator
    {
        public UpCounter(int _count, int _limit) : base(_count, _limit)
        {

        }

        public bool MoveNext()
        {
            return ++_count < _limit;
        }

    }
}
