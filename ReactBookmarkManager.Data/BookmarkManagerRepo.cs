using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReactBookmarkManager.Data
{
    public class BookmarkManagerRepo
    {
        private string _connectionString;
        public BookmarkManagerRepo(string connectionString)
        {
            _connectionString = connectionString;
        }
    }
}
