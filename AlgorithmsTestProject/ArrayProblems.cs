using System.Text;

namespace AlgorithmsTestProject;

public static class ArrayProblems
{
    public static bool AreArraysEqual<T>(T[] xs, T[] ys)
    {
        if (xs == ys) {
            return true;
        }
        return false;
    }

    public static void Swap<T>(T[] xs, int a, int b)
    {
        if (xs.Length < 2) {
            throw new IndexOutOfRangeException();
        }

        else {
            T temp = xs[a];
            xs[a] = xs[b];
            xs[b] = temp;
        }
    }

    public static T FirstElement<T>(T[] xs)
    {
        if (xs.Length < 1) {
            throw new IndexOutOfRangeException();
        }
        else {
            return xs[0];
        }
    }

    public static T LastElement<T>(T[] xs)
    {
        if(xs.Length < 1) {
            throw new IndexOutOfRangeException();
        }
        else
        {
            return xs[xs.Length - 1];
        }
    }

    public static T MiddleElement<T>(T[] xs)
    {
        if (xs.Length < 1)
        {
            throw new IndexOutOfRangeException();
        }
        else
        {
            return xs[xs.Length / 2];
        }
    }

    public static void Reverse<T>(T[] xs)
    {
        Array.Reverse(xs);
    }

    public static int CountElement<T>(T[] xs, T element)
    {
        return xs.Count(x => x.Equals(element));
    }

    public static string ToCommaDelimitedString<T>(T[] xs)
    {
        var sb = new StringBuilder();
        for (var i = 0; i < xs.Length; ++i)
        {
            if (i > 0) sb.Append(',');
            sb.Append(xs[i].ToString());
        }
        return sb.ToString();
    }

    // Bonus problems

    public static int Count<T>(T[] xs, Func<T, bool> predicate)
    {
        return xs.Count(predicate);
    }

    public static T Min<T>(T[] xs, Func<T, T, int> comparer)
    {
        if (xs.Length < 1)
        {
            throw new IndexOutOfRangeException();
        }
        else
        {
            return xs.Min();
        }
    }

    public static T Max<T>(T[] xs, Func<T, T, int> comparer)
    {
        if (xs.Length < 1)
        {
            throw new IndexOutOfRangeException();
        }
        else
        {
            return xs.Max();
        }
    }

    public static bool HasDuplicates<T>(T[] xs)
    {
        return xs.Distinct().Count() != xs.Length;
    }
}