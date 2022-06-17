using System;
using System.Collections.Generic;

namespace _Delegate_Extension
{
    public static class Extentions
    {
        public static int _Count<T>(this IEnumerable<T> source, Func<T, bool> func)
        {
            if (source == null) throw new ArgumentNullException("source");
            if (func == null) throw new ArgumentNullException("func");
            int count = 0;
            
            foreach (T element in source)
            {
                checked
                {
                    if (func(element)) count++;
                }
            }
            return count;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<string>() { "abc", "aab", "dss", "rde"};
            var res = list._Count(x => x.Contains("b"));
        }
    }
}
