using ProxyPatternExample.Objects;

namespace ProxyPatternExample
{
    public class LazyBookParserProxy : IBookParser
    {
        private IBookParser _bookParser;
        private readonly string _book;

        public LazyBookParserProxy(string book)
        {
            _book = book;
        }

        public int GetPageCount()
        {
            if (_bookParser == null)
            {
                _bookParser = new BookParser(_book);
            }

            return _bookParser.GetPageCount();
        }
    }
}