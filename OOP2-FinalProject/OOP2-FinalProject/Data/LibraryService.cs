using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2_FinalProject.Data
{
    internal class LibraryService
    {
        private readonly SQLiteAsyncConnection _connection;

        public LibraryService(string BookPath)
        {
            _connection = new SQLiteAsyncConnection(BookPath);
            _connection.CreateTableAsync<Book>().Wait();
            _connection.CreateTableAsync<User>().Wait();
            _connection.CreateTableAsync<Rental>().Wait();
        }

        // Book Section
        public async Task<List<Book>> GetBooksListAsync()
        {
            return await _connection.Table<Book>().ToListAsync();
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

        // User Section
        public async Task<List<User>> GetUsersListAsync()
        {
            return await _connection.Table<User>().ToListAsync();
        }

        public Task<User> GetUserAsync(int idNum)
        {
            return _connection.Table<User>()
                .Where(i => i.IdNum == idNum)
                .FirstOrDefaultAsync();
        }

        public Task<int> SaveUserAsync(User user)
        {
            if (user.IdNum != 0)
            {
                return _connection.UpdateAsync(user);
            }
            else
            {
                return _connection.InsertAsync(user);
            }
        }

        public Task<int> DeleteUserAsync(User user)
        {
            return _connection.DeleteAsync(user);
        }

        // Rental Section
        public Task<List<Rental>> GetRentalsListAsync()
        {
            return _connection.Table<Rental>().ToListAsync();
        }

        public Task<Rental> GetRentalsAsync(int rentNum)
        {
            return _connection.Table<Rental>()
                .Where(i => i.RentNum == rentNum)
                .FirstOrDefaultAsync();
        }

        public Task<int> SaveRentalAsync(Rental rental)
        {
            if (rental.RentNum != 0)
            {
                rental.ReturnDate = rental.BorrowDate.AddDays(14);
                return _connection.UpdateAsync(rental);
            }
            else
            {
                rental.ReturnDate = rental.BorrowDate.AddDays(14);
                return _connection.InsertAsync(rental);
            }
        }

        public Task<int> ReturnBookAsync(Rental rental)
        {
            return _connection.DeleteAsync(rental);
        }

        public void SetReturnDate(DateTime startDate, Rental rental)
        {
            rental.ReturnDate = startDate.AddDays(14);
        }


    }
}
