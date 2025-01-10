using DataAccess.Abstract;
using DataAccess.Repositories;
using Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfReviewRepository : GenericRepository<Review>, IReviewDal
    {
        public List<Review> GetListWithCategory()
        {
            using (var context = new Context())
            {
                return context.Reviews.Include(x => x.Category).ToList();
            }
        }
    }
}
