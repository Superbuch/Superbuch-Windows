using Superbuch.Entities;
using System.Linq;

namespace Superbuch.Contracts
{
    interface IDataContext
    {

        bool Login(string dbPath, string Password);
        bool ChangeDatabasePassword(string oldPassword, string newPassword);
        bool CreateNewDatebase(string dbPath, string dbPassword);

        IQueryable<Account> Accounts { get; set; }
        IQueryable<Account> Categories { get; set; }
        IQueryable<Account> Bookings { get; set; }

    }
}