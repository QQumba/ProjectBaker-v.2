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

		protected DbSet<Review> Set
		{
			get { return _db.Reviews; }
		}

		public void AddReview(Review user)
		{
			Set.Add(user);
		}

		public void DeleteReview(Review review)
		{
			Set.Remove(review);
		}

		public List<Review> GetAllReviews()
		{
			return Set.Select(r => r).ToList();
		}

		public Review GetReviewById(int id)
		{
			return Set.FirstOrDefault(r => r.Id == id);
		}

		public List<Review> GetUserReviews(string userEmail)
		{
			return Set.Select(r => r).Where(r => r.UserEmail == userEmail).ToList();
		}

		public List<Review> PageReviews(int skip, int take)
		{
			return Set.Skip(skip).Take(take).ToList();
		}

		public void UpdateReview(Review review)
		{
			Set.Update(review);
		}
	}
}
