using System;

namespace ProxyPatternExample
{
    internal static class ProxyPatternExample
    {
        /*
         * The majority of this code is mocked or directly taken from the Christopher Okhravi YouTube series in
         * an effort to teach myself and get familiar with these patterns.  None of this is meant to be
         * original content, and if you see this and wonder why it's in my repo, mostly it's for me, but
         * I'm happy that you're here and here's proof that I have at least heard of this particular
         * pattern!
         *
         * Author: Nicholas Larsen
         * Date: 2021/10/11
         */
        
        private static void Main()
        {
            // The proxy pattern allows for lazy instantiation, used a lot for db processing, if you don't need something
            // you have the option to access it without the cost until you actually need it
            var watch = new System.Diagnostics.Stopwatch();
            var bookParser = new LazyBookParserProxy("The King and I");
            
            // We Instantiate the object the first time, which takes a minute
            watch.Start();
            Console.WriteLine("Page Count: " + bookParser.GetPageCount());
            watch.Stop();
            Console.WriteLine($"Execution Time (Pre-Instantiation): {watch.ElapsedMilliseconds} ms");

            watch.Reset();
            
            // Then we already have it so it takes no time
            watch.Start();
            Console.WriteLine("Page Count: " + bookParser.GetPageCount());
            watch.Stop();
            Console.WriteLine($"Execution Time (Post-Instantiation): {watch.ElapsedMilliseconds} ms");

        }
    }
}