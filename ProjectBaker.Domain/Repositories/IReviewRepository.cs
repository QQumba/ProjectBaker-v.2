using ProjectBaker.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ProjectBaker.Domain.Repositories
{
	public interface IReviewRepository
	{
		void AddReview(Review user);
		Review GetReviewById(int id);
		List<Review> GetAllReviews();
		List<Review> GetUserReviews(string userEmail);
		List<Review> PageReviews(int skip, int take);
		void UpdateReview(Review review);
		void DeleteReview(Review review);
	}
}
