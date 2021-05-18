
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ServiceTest
{


    internal class TestDbAsyncEnumerable<T> : List<T>, IAsyncEnumerable<T> //EnumerableQuery<T>,  IQueryable<T>
    {
        public TestDbAsyncEnumerable(IEnumerable<T> enumerable)
            : base(enumerable)
        { }

       
        public IAsyncEnumerator<T> GetAsyncEnumerator(CancellationToken cancellationToken = default) => new TestDbAsyncEnumerator<T>(GetEnumerator());
        
    }

    internal class TestDbAsyncEnumerator<T> : IAsyncEnumerator<T>
    {
        private readonly IEnumerator<T> _inner;

        public TestDbAsyncEnumerator(IEnumerator<T> inner)
        {
            _inner = inner;
        }

        public void Dispose()
        {
            _inner.Dispose();
        }

        public Task<bool> MoveNextAsync(CancellationToken cancellationToken)
        {
            return Task.FromResult(_inner.MoveNext());
        }

        public ValueTask<bool> MoveNextAsync()
        {
            return new ValueTask<bool>(_inner.MoveNext());
        }

        public ValueTask DisposeAsync()
        {
            _inner.Dispose();

            return new ValueTask(Task.CompletedTask);
        }

        public T Current
        {
            get { return _inner.Current; }
        }

    }
}