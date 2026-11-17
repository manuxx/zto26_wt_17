using System.Collections;
using System.Collections.Generic;

namespace Training.DomainClasses;

public class ReadOnlySet<TItem>(IEnumerable<TItem> items) : IEnumerable<TItem>
{
    public IEnumerator<TItem> GetEnumerator()
    {
        return items.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}