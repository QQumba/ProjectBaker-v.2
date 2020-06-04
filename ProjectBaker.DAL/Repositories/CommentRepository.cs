using Microsoft.EntityFrameworkCore;
using ProjectBaker.Domain.Entities;
using ProjectBaker.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectBaker.DAL.Repositories
{
	public class CommentRepository : ICommentRepository
	{
		private AppDbContext _db;

		public CommentRepository(AppDbContext context)
		{
			_db = context;
		}

		public void AddComment(Comment comment)
		{
			_db.Comments.Add(comment);
		}

		public void DeleteComment(Comment comment)
		{
			_db.Comments.Remove(comment);
		}

		public List<Comment> GetAllComments()
		{
			return _db.Comments.Select(c => c).ToList();
		}

		public Comment GetCommentById(int id)
		{
			return _db.Comments.FirstOrDefault(c => c.Id == id);
		}

		public List<Comment> GetProjectComments(int projectId)
		{
			return _db.Comments.Select(c => c).Where(c => c.ProjectId == projectId).ToList();
		}

		public List<Comment> GetUserComments(string userEmail)
		{
			return _db.Comments.Select(c => c).Where(c => c.User.Email == userEmail).ToList();
		}

		public List<Comment> PageComments(int skip, int take)
		{
			return _db.Comments.Skip(skip).Take(take).ToList();
		}

		public void UpdateComment(Comment comment)
		{
			_db.Comments.Update(comment);
		}
	}
}
