namespace MyExtensions;

public static class MyLinq
{
    public static T First<T>(this IEnumerable<T>? collection, Predicate<T>? cond = null)
    {
        var enumerable = (collection ?? throw new InvalidOperationException()).ToArray();
        if (enumerable.Length == 0) throw new InvalidOperationException();
        foreach (var i in enumerable)
        {
            if (i != null && (cond?.Invoke(i) ?? true)) return i;
        }

        throw new InvalidOperationException();
    }

    public static T? FirstOrDefault<T>(this IEnumerable<T>? collection, Predicate<T>? cond = null)
    {
        if (collection == null) return default;
        var enumerable = collection.ToArray();
        if (enumerable.Length == 0) return default;
        foreach (var i in enumerable)
        {
            if (i != null && (cond?.Invoke(i) ?? true)) return i;
        }

        return default;
    }

    public static IEnumerable<T> Where<T>(this IEnumerable<T>? collection, Predicate<T> cond)
    {
        var temp = new List<T>();
        if (collection == null) return temp;
        var enumerable = collection.ToArray();
        if (enumerable.Length == 0) return temp;
        foreach (var i in enumerable)
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
        if (collection == null) return false;
        var enumerable = collection.ToArray();
        if (enumerable.Length == 0) return false;
        foreach (var i in enumerable)
        {
            if (i != null && cond.Invoke(i)) return true;
        }

        return false;
    }
}