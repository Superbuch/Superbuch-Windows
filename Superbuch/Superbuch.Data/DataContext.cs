using System;
using System.Linq;
using Superbuch.Contracts;
using Superbuch.Entities;

namespace Superbuch.Data
{
    class DataContext : IDataContext
    {

        private readonly SuperDataContext superDataContext = new SuperDataContext();

        public IQueryable<Account> Accounts
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public IQueryable<Account> Bookings
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public IQueryable<Account> Categories
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public bool ChangeDatabasePassword(string oldPassword, string newPassword)
        {
            throw new NotImplementedException();
        }

        public bool CreateNewDatebase(string dbPath, string dbPassword)
        {
            throw new NotImplementedException();
        }

        public bool Login(string dbPath, string Password)
        {
            throw new NotImplementedException();
        }

    }
}
