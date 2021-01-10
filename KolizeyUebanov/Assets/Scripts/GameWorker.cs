using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public static class GameWorker
{
    public static int CountOfHeroes;

    public static TType Next<TType>(this IList<TType> list, TType item)
    {
        if (list == null) return default(TType);

        var itemIndex = list.IndexOf(item);
        if (itemIndex < 0) return list.FirstOrDefault();

        var nextIndex = itemIndex + 1;

        return nextIndex >= list.Count
            ? list.FirstOrDefault()
            : list[nextIndex];
    }

    public static TType Prew<TType>(this IList<TType> list, TType item)
    {
        if (list == null) return default(TType);

        var itemIndex = list.IndexOf(item);
        if (itemIndex < 0) return list.FirstOrDefault();

        var nextIndex = itemIndex - 1;

        return nextIndex < 0
            ? list.LastOrDefault()
            : list[nextIndex];
    }
}
