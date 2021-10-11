using System;

namespace ProxyPatternExample.Objects
{
    public class BookParser : IBookParser
    {
        private string LongString { get; } = "";
        
        public BookParser(string book)
        {
            var random = new Random();
            for (var i = 0; i < random.Next(100000, 9999999); i++)
            {
                LongString += book[i % (book.Length-1)];
            }
        }


        public int GetPageCount()
        {
            return LongString.Length;
        }
    }
}