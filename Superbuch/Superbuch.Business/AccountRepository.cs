using Superbuch.Contracts;
using Superbuch.Entities;

namespace Superbuch.Business
{
    public class AccountRepository : Repository<Account>, IAccountRepository
    {

        public AccountRepository(IDataContext dataContext) : base(dataContext)
        {
            this.DataContext = dataContext; 
        }
    }
}
