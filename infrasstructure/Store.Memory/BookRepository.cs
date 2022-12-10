using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Store.Memory
{
    public class BookRepository : IBookRepository
    {
        private readonly Book[] books = new[]
        {
            new Book(1, "ISBN 00000-00001", "D. Knuth", "Art Of Programming"),
            new Book(2, "ISBN 00000-00002", "M. Fowler", "Refactoring"),
            new Book(3, "ISBN 00000-00003", "B. Kernigan, D. Ritchie", "C Programming Language"),
        };

        public Book[] GetAllByIsbn(string isbn)
        {
           return books.Where(books => books.Isbn == isbn).ToArray();
        }

        public Book[] GetAllByTitleOrAutor(string titleOrAutor)
        {
            return books.Where(b => b.Autor.Contains(titleOrAutor) ||
                                    b.Title.Contains(titleOrAutor))
                        .ToArray();
        }
    }
}
