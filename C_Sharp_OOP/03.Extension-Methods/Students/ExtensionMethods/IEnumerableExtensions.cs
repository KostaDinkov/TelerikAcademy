using System;
using System.Collections.Generic;
using System.Linq;

namespace Homework.ExtensionMethods
{
    public static class IEnumerableExtensions
    {
        public static T MyMin<T>(this IEnumerable<T> collection)
        {
            if (collection == null)
            {
                throw new ArgumentNullException(nameof(collection));
            }

            Comparer<T> comparer = Comparer<T>.Default;
            T value = default(T);
            if (value == null)
            {
                using (IEnumerator<T> e = collection.GetEnumerator())
                {
                    do
                    {
                        if (!e.MoveNext())
                        {
                            return value;
                        }

                        value = e.Current;
                    } while (value == null);

                    while (e.MoveNext())
                    {
                        T x = e.Current;
                        if ((x != null) && (comparer.Compare(x, value) < 0))
                        {
                            value = x;
                        }
                    }
                }
            }
            else
            {
                using (IEnumerator<T> e = collection.GetEnumerator())
                {
                    if (!e.MoveNext())
                    {
                        throw new ArgumentException("No elements");
                    }

                    value = e.Current;
                    while (e.MoveNext())
                    {
                        T x = e.Current;
                        if (comparer.Compare(x, value) < 0)
                        {
                            value = x;
                        }
                    }
                }
            }

            return value;
        }

        public static T MyMax<T>(this IEnumerable<T> collection)
        {
            if (collection == null)
            {
                throw new ArgumentNullException(nameof(collection));
            }

            Comparer<T> comparer = Comparer<T>.Default;
            T value = default(T);
            if (value == null)
            {
                using (IEnumerator<T> e = collection.GetEnumerator())
                {
                    do
                    {
                        if (!e.MoveNext())
                        {
                            return value;
                        }

                        value = e.Current;
                    }
                    while (value == null);

                    while (e.MoveNext())
                    {
                        T x = e.Current;
                        if (x != null && comparer.Compare(x, value) > 0)
                        {
                            value = x;
                        }
                    }
                }
            }
            else
            {
                using (IEnumerator<T> e = collection.GetEnumerator())
                {
                    if (!e.MoveNext())
                    {
                        throw new ArgumentException("No elements");
                    }

                    value = e.Current;
                    while (e.MoveNext())
                    {
                        T x = e.Current;
                        if (comparer.Compare(x, value) > 0)
                        {
                            value = x;
                        }
                    }
                }
            }

            return value;
        }
        
        // Since there is no common interface for numeric types in C#
        // I will use a simple hack - which is highly inefficient,
        // but the problem specification is badly thought anyway, so...
        public static decimal MySum<T>(this IEnumerable<T> collection) where T:IConvertible
        {
            decimal sum = Convert.ToDecimal(default(T));
            foreach (T element in collection)
            {
                sum += Convert.ToDecimal(element);
                
            }
            return sum;
        }
        
        public static decimal MyAverage<T>(this IEnumerable<T> collection) where T: IConvertible
        {
            decimal elementCount = collection.Count();
            decimal sum = collection.MySum();
            return sum / elementCount;
        }

        public static decimal MyProduct<T>(this IEnumerable<T> collection) where T : IConvertible
        {
            
            decimal product = 1;
            foreach (T element in collection)
            {
                product *= Convert.ToDecimal(element); // note possible overflow
            }
            return product;
        }


    }
}