using Superbuch.Entities;
using System.Linq;

namespace Superbuch.Contracts
{
    public interface IDataContext
    {

        bool Login(string dbPath, string Password);
        bool ChangeDatabasePassword(string oldPassword, string newPassword);
        bool CreateNewDatebase(string dbPath, string dbPassword);

        IQueryable<Account> Accounts { get; }
        IQueryable<Account> Categories { get; }
        IQueryable<Account> Bookings { get; }

    }
}