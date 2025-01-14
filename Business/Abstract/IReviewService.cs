using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IReviewService
    {
        void ReviewAdd(Review review);
        void ReviewDelete(Review review);
        void ReviewUpdate(Review review);
        List<Review> GetAllReviews();
        Review GetById(int id);
        List<Review> GetReviewListWithCategory();
        List<Review> GetReviewListWithWriter(int id);
        int GetWriterWithReview(int reviewId);
    }
}
