using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2_FinalProject.Data
{
    internal class BookService
    {
        private readonly SQLiteAsyncConnection _connection;

        public BookService(string BookDBPath)
        {
            _connection = new SQLiteAsyncConnection(BookDBPath);
            _connection.CreateTableAsync<Book>().Wait();
        }

        public Task<List<Book>> GetBooksListAsync()
        {
            return _connection.Table<Book>().ToListAsync();
        }

        public Task<Book> GetBookAsync(int id)
        {
            return _connection.Table<Book>()
                .Where(i => i.Id == id)
                .FirstOrDefaultAsync();
        }

        public Task<int> SaveBookAsync(Book book)
        {
            if (book.Id != 0)
            {
                return _connection.UpdateAsync(book);
            }
            else
            {
                return _connection.InsertAsync(book);
            }
        }

        public Task<int> DeleteBookAsync(Book book)
        {
            return _connection.DeleteAsync(book);
        }
    }
}
