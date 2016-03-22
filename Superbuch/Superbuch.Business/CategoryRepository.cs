using Superbuch.Contracts;
using Superbuch.Entities;

namespace Superbuch.Business
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {

        public CategoryRepository(IDataContext dataContext) : base(dataContext)
        {
            this.DataContext = dataContext; 
        }
    }
}
