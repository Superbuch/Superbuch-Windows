using System;

namespace Superbuch.Contracts
{
    interface IUnitOfWork : IDisposable
    {

        IAccountRepository Accounts { get; }
        ICategoryRepository Categories { get; }
        IBookingRepository Bookings { get; }
        int Complete();

    }
}