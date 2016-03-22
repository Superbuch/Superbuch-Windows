using Superbuch.Contracts;
using Superbuch.Entities;

namespace Superbuch.Business
{
    public class BookingRepository : Repository<Booking>, IBookingRepository
    {

        public BookingRepository(IDataContext dataContext) : base(dataContext)
        {
            this.DataContext = dataContext; 
        }
    }
}
