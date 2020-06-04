using Microsoft.EntityFrameworkCore;
using ProjectBaker.Domain.Entities;
using ProjectBaker.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectBaker.DAL.Repositories
{
	public class ReviewRepository : IReviewRepository
	{
		private AppDbContext _db;

		public ReviewRepository(AppDbContext context)
		{
			_db = context;
		}

		public void AddReview(Review user)
		{
			throw new NotImplementedException();
		}

		public void DeleteReview(Review review)
		{
			throw new NotImplementedException();
		}

		public List<Review> GetAllReviews()
		{
			throw new NotImplementedException();
		}

		public Review GetReviewById(int id)
		{
			throw new NotImplementedException();
		}

		public List<Review> GetUserReviews(string userEmail)
		{
			throw new NotImplementedException();
		}

		public List<Review> PageReviews(int skip, int take)
		{
			throw new NotImplementedException();
		}

		public void UpdateReview(Review review)
		{
			throw new NotImplementedException();
		}
	}
}
