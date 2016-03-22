using System;

namespace Superbuch.Contracts
{
    public interface IUnitOfWork : IDisposable
    {

        IAccountRepository Accounts { get; }
        ICategoryRepository Categories { get; }
        IBookingRepository Bookings { get; }
        int Complete();

    }
}