using Business.Abstract;
using DataAccess.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ReviewManager : IReviewService
    {
        IReviewDal _reviewDal;
        public ReviewManager(IReviewDal reviewDal)
        {
            _reviewDal = reviewDal;
        }

        public List<Review> GetAllReviews()
        {
            return _reviewDal.GetAll();
        }

        public Review GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void ReviewAdd(Review review)
        {
            throw new NotImplementedException();
        }

        public void ReviewDelete(Review review)
        {
            throw new NotImplementedException();
        }

        public void ReviewUpdate(Review review)
        {
            throw new NotImplementedException();
        }

        public List<Review> GetReviewById(int id)
        {
            return _reviewDal.GetAll(x=>x.ReviewID == id);
        }

        public List<Review> GetReviewListWithCategory()
        {
            return _reviewDal.GetListWithCategory();
        }

        public int GetWriterWithReview(int reviewId)
        {
            return _reviewDal.GetAll(x => x.ReviewID == reviewId).Select(x => x.WriterID).FirstOrDefault();
        }

        public List<Review> GetReviewListWithWriter(int id)
        {
            return _reviewDal.GetAll(x => x.WriterID == id);
        }
    }
}
