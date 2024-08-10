//using SQLite;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace OOP2_FinalProject.Data
//{
//    internal class UserService
//    {
//        private readonly SQLiteAsyncConnection _connection;

//        public UserService(string UserDBPath)
//        {
//            _connection = new SQLiteAsyncConnection(UserDBPath);
//            _connection.CreateTableAsync<User>().Wait();
//        }

//        public Task<List<User>> GetUsersListAsync()
//        {
//            return _connection.Table<User>().ToListAsync();
//        }

//        public Task<User> GetUserAsync(int idNum)
//        {
//            return _connection.Table<User>()
//                .Where(i => i.IdNum == idNum)
//                .FirstOrDefaultAsync();
//        }

//        public Task<int> SaveUserAsync(User user)
//        {
//            if (user.IdNum != 0)
//            {
//                return _connection.UpdateAsync(user);
//            }
//            else
//            {
//                return _connection.InsertAsync(user);
//            }
//        }

//        public Task<int> DeleteUserAsync(User user)
//        {
//            return _connection.DeleteAsync(user);
//        }
//    }
//}
