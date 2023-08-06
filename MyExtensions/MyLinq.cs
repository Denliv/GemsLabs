namespace MyExtensions;

public static class MyLinq
{
    public static T First<T>(this IEnumerable<T>? collection)
    {
        if (collection == null || !Enumerable.Any(collection)) throw new InvalidOperationException();
        return collection.ElementAt(0);
    }

    public static T First<T>(this IEnumerable<T>? collection, Predicate<T> cond)
    {
        if (collection == null || !Enumerable.Any(collection)) throw new InvalidOperationException();
        foreach (var i in collection)
        {
            if (i != null && cond.Invoke(i)) return i;
        }

        throw new InvalidOperationException();
    }

    public static T? FirstOrDefault<T>(this IEnumerable<T>? collection)
    {
        if (collection == null || !Enumerable.Any(collection)) return default;
        return collection.ElementAt(0);
    }

    public static T? FirstOrDefault<T>(this IEnumerable<T>? collection, Predicate<T> cond)
    {
        if (collection == null || !Enumerable.Any(collection)) return default;
        foreach (var i in collection)
        {
            if (i != null && cond.Invoke(i)) return i;
        }

        return default;
    }

    public static IEnumerable<T> Where<T>(this IEnumerable<T>? collection, Predicate<T> cond)
    {
        var temp = new List<T>();
        if (collection == null || !Enumerable.Any(collection)) return temp;
        foreach (var i in collection)
        {
            if (i != null && cond.Invoke(i)) temp.Add(i);
        }

        return temp;
    }

    public static bool Any<T>(this IEnumerable<T>? collection)
    {
        return collection != null && Enumerable.Any(collection);
    }

    public static bool Any<T>(this IEnumerable<T>? collection, Predicate<T> cond)
    {
        if (collection == null || !Enumerable.Any(collection)) return false;
        foreach (var i in collection)
        {
            if (i != null && cond.Invoke(i)) return true;
        }

        return false;
    }
}