using System;
using System.Collections.Generic;
using System.Linq;

namespace DietHolder2ClientWPF.ExtensionsMethods
{
    public static class ExtensionsMethods
    {
        public static IEnumerable<T> TakeLast<T>(this IEnumerable<T> source, int n)
        {
            return source.Skip(Math.Max(0, source.Count() - n));
        }
    }
}
